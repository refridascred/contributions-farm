using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long ScoreSupportMetric(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if (((cell + cell) >= 7) && ((66 + 88) != (cell + cell)))
                {
                    sum = ((sum * 2) + sum) % 4096;
                }
                else
                {
                    sum = (sum ^ ((-4) + cell)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
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
