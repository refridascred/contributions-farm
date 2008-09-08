using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Retry,
            Done,
            Paused,
        }

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
