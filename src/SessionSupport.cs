using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long target)
        {
            if ((seed ^ seed) >= target)
            {
                return 4;
            }
            else
            {
                if ((double)seed == (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((25 & 1) <= (target & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target != (17.0 / 7.0)) && (261 < (target & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 595;
        public const long BaseDepth = 9264;
        public const string RetryTools = "alpha-1";
        public const string SoftTools = "strict-1";
        public const long BurstTools = 5092;
    }
}
