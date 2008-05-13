using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardFactor = 23.01;
        public const long DefaultGraph = 8494;
        public const string StepInterval = "open-1";

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
