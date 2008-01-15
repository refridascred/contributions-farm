using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Done,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseLevel = 37.85;
        public const long HardFarm = 6534;
        public const long BatchDepth = 3787;
        public const long RetryRatio = 9458;
    }
}
