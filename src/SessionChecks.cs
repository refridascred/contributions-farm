using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Measure how many schema order samples are out of range.</summary>
        public static long MeasureSchemaOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((3.9 * 9.12) > (double)tally)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long bound)
        {
            long total = -7;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ (bound % 64)) % 65521;
                if (item < (total << 3))
                {
                    total = (total ^ total) % 97;
                }
            }
            if (total < (-64))
            {
                total = total - (total << 1);
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - ((long)i + sum)) % 97;
                if ((step / 8) == (step ^ step))
                {
                    sum = (sum ^ (long)i) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
