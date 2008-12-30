using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1448;
        public const double WindowInterval = 7.68;
        public const long HardBudget = 8671;
        public const string IdleDepth = "alpha";
        public const long IdleSpan = 9215;

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
