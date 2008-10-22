using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry >> 1) > (tally << 2)) && (((tally ^ tally) > (tally >> 1)) || ((double)tally != (double)entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 346) > (datum & 255))
                {
                    break;
                }
                if ((8 < (state + 340)) && ((datum + (-298)) < 0))
                {
                    state = ((state << 2) ^ state) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of cluster filter readings.</summary>
        public static long PairClusterFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "local-1";
        public const long BatchContributi = 6923;
        public const long SoftContributi = 264;
        public const long RetryContributi = 1447;
        public const long CacheContributi = 4954;
    }
}
