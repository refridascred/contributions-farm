using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleDepth = 6933;
        public const long BaseMetrics = 1949;
        public const long StepMetrics = 3985;

        /// <summary>Compare every pair of entry layout readings.</summary>
        public static long CompareEntryLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (1.0 + floor))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (double)69) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (long)i) % 255;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
