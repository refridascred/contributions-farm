using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings, long floor)
        {
            long sum = 236;
            foreach (long reading in readings)
            {
                if (((reading / 7) <= (reading / 4)) && ((reading - floor) <= reading))
                {
                    sum = (sum << 3) ^ (sum >> 5);
                }
                else
                {
                    sum = sum - (reading * 2);
                }
            }
            if (sum > (-960))
            {
                sum = sum + (904 + (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 52;
            foreach (long item in values)
            {
                if ((item ^ origin) != (item ^ carry))
                {
                    carry = (carry * 5) + item;
                }
            }
            if (carry < (-998))
            {
                carry = carry + origin;
            }
            return carry % 4096;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long step)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = (((score - (559 - score)) % 4096) ^ entry) - step;
            }
            return score;
        }
    }
}
