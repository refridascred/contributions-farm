using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((15.0 / 4.0) != (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= (82 ^ origin))
                {
                    return 5;
                }
                else
                {
                    if (origin >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 1637;
        public const string BatchMetric = "alpha-v2";
        public const long StepMetric = 558;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
