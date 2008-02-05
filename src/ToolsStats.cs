using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Active,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (95 <= (sample + step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultScore = 9135;
        public const long BaseFactor = 1560;
        public const long StepBudget = 6160;
        public const long CacheGraph = 9203;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7335;
        public const long BatchSpan = 5065;
        public const string RetryChannel = "stable-v2";
        public const string WindowRatio = "standard";
    }
}
