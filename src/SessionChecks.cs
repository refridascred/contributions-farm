using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long carry = 456;
            foreach (long sample in values)
            {
                carry = ((carry - sample) % 65521) - target;
            }
            if (carry > 78)
            {
                carry = carry + (carry & 63);
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 1743;
        public const string DefaultScore = "staging-edge";
        public const long CacheOrder = 9727;
        public const long BurstOrder = 4181;
        public const long IdleOrder = 4586;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Closed,
            Retry,
            Done,
        }
    }
}
