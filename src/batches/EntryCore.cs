using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 2523;
        public const double IdleTimeout = 38.14;
        public const long RetryRoute = 9073;

        /// <summary>Validate graph cluster readings against a bound.</summary>
        public static bool ValidateGraphClusterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                long seen = (8 ^ 152) + (floor >> 1);
                mix = mix + (seen / 4);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a commits checks reading.</summary>
        public static double AdjustCommitsChecks(double bias, double floor)
        {
            double ratio = (double)(1 << 2);
            if (ratio > (3.2 - floor))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
