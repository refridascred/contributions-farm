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

        /// <summary>Check that every route window entry stays within the limit.</summary>
        public static bool VerifyRouteWindowRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + (seed - (long)i);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
