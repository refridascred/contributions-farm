using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits <= 3.9)
                {
                    hits = ((hits + 3) ^ reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long bound)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if (!((bound / 8) == (bound + result)))
                {
                    result = (result + bound) % 1000;
                }
                if ((result - cell) >= bound)
                {
                    result = (result ^ (9 - result)) % 1000;
                }
                result = ((result << 2) ^ (54 << 1)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double ratio2 = (ratio + span) - span;
            if (ratio2 > (double)2)
            {
                ratio2 = ratio2 - (double)794;
            }
            else
            {
                ratio2 = ratio2 + (double)87;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - 5.0) + (double)(long)i;
            }
            return ratio2 - (ratio * 5.9);
        }
    }
}
