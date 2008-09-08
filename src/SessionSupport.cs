using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "staging-edge";
        public const string WindowRatio = "latest-1";
        public const long MinSpan = 3065;
        public const long LimitInterval = 5640;
        public const long RetryBuffer = 4107;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long origin)
        {
            if ((1.5 > (double)origin) && ((origin ^ origin) != (origin & 31)))
            {
                return 6;
            }
            else
            {
                if (!((origin + 769) >= 0))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ bound) >= (origin + 91))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 5) < bound) || (origin >= (bound - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
