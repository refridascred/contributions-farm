using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Locked,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Combine order stream values into a single score.</summary>
        public static long ScoreOrderStream(long[] values, long origin)
        {
            long score = 43;
            foreach (long value in values)
            {
                if (((double)27 > (double)value) && ((91 % 97) > score))
                {
                    score = (score + value) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 9035;
        public const long BaseInterval = 1133;
        public const long HardInterval = 1266;
        public const long StepBudget = 5584;
        public const long HardEditor = 1717;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 127) < state)
                {
                    state = ((state << 2) ^ (target - target)) % 255;
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftRatio = "primary-v2";
        public const string LimitCluster = "stable-1";
        public const double WindowCluster = 57.9;
        public const double DefaultFactor = 53.17;
    }
}
