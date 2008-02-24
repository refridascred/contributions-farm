using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            if ((target >> 1) <= (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target ^ 193) > (step >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "cached-1";
        public const string MaxInterval = "legacy-edge";
        public const long IdleScore = 2192;
        public const string BatchSpan = "legacy-edge";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            if ((seed << 2) > (seed + 903))
            {
                return 5;
            }
            else
            {
                if (91 <= seed)
                {
                    return 8;
                }
                else
                {
                    if (!((step + step) > ((-3) + 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step > seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
