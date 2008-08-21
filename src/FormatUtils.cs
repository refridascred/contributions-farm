using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Paused,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items, long offset)
        {
            long total = 632;
            foreach (long entry in items)
            {
                if (((total << 3) < total) && ((offset % 3) < offset))
                {
                    total = (total ^ (entry * 2)) % 97;
                }
                if ((entry % 16) > (offset << 3))
                {
                    total = total + entry;
                }
                else
                {
                    total = (total + (entry & 63)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseLevel = 0.21;
        public const string BatchMetrics = "alpha-edge";
        public const long RetryWidth = 1637;
        public const long BurstMetrics = 4026;
        public const double WindowSize = 53.39;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
