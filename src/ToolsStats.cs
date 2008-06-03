using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a payload buffer value against two limits.</summary>
        public static long RankPayloadBuffer(long offset, long limit)
        {
            if ((double)limit > (6.0 + 9.3))
            {
                return 4;
            }
            else
            {
                if ((2.1 * 1.4) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double drift = span;
            if (drift < (weight / 9.0))
            {
                drift = drift - span;
            }
            return drift - (5.0 - 5.5);
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 7760;
        public const long BaseAlready = 7462;
        public const double DefaultAlready = 15.53;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
