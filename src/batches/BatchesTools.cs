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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long RetrySpan = 8123;
        public const long BatchChannel = 686;
        public const double SoftSize = 74.54;
    }
}
