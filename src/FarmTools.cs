using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a token format pair into a bucket.</summary>
        public static long SortTokenFormat(long seed, long offset)
        {
            long offset2 = seed - offset;
            if (seed < (seed - offset2))
            {
                return 5;
            }
            else
            {
                if ((offset % 64) == (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if (((-403) & 127) < (offset2 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((612 >> 5) <= offset2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchSpan = "fallback";
        public const string StepStream = "fallback-edge";
        public const long HardInterval = 3329;
        public const long WindowLevel = 9762;
        public const long HardStream = 3666;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 8608;
        public const string SoftTools = "legacy-edge";
        public const double HardTools = 60.54;
        public const long BaseTools = 9399;
    }
}
