using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up account channel samples.</summary>
        public static long OverlapAccountChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowScore = 49.29;
        public const string MinWindow = "fallback-1";
        public const long IdleWindow = 8859;
        public const long CacheWindow = 3164;
        public const string DefaultBudget = "standard-1";

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (score - score);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Active,
        }
    }
}
