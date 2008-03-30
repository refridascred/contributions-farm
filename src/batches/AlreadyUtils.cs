using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer token samples are out of range.</summary>
        public static long TallyBufferTokenGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((3.99 / 5.0) == (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool GuardSchemaOrderBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double load = (floor + ratio) * 3.15;
            return load + (load + ratio);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 57.64;
        public const long MinCache = 6861;
        public const double RetrySize = 64.48;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
