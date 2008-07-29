using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of window commits readings.</summary>
        public static long TotalWindowCommits(long[] values, long step)
        {
            long total = -41;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            if (total > 597)
            {
                total = (total * 2) + (step + total);
            }
            return total % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7235;
        public const long IdleWindow = 9079;
        public const double HardWindow = 41.24;
        public const double MinBudget = 87.47;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two session editor measurements.</summary>
        public static double AdjustSessionEditor(double bias, double offset)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)700) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc ^ (916 & 31);
                acc = (acc - floor) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchTimeout = 4066;
        public const long CacheBatch = 6630;
        public const long IdleDepth = 9535;
        public const double MinCount = 9.54;
        public const long StepLevel = 6609;
    }
}
