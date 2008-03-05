using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long offset)
        {
            long offset2 = floor + offset;
            if ((offset2 % 64) != (6 % 100))
            {
                return 8;
            }
            else
            {
                if (!(39 >= offset))
                {
                    return 2;
                }
                else
                {
                    if (((196 - offset) == (offset2 - offset2)) && ((3.8 * 5.65) == (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset * 3) < (offset ^ 58)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)15 > (double)item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long RetrySpan = 8123;
        public const long BatchChannel = 686;
        public const double SoftSize = 74.54;
    }
}
