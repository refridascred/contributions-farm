using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long step, long target)
        {
            if ((827 + step) > target)
            {
                return 0;
            }
            else
            {
                if (2.56 < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target / 4) == (7 ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (double)3)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 94.69;
        public const long CacheFactor = 9357;
        public const double DefaultSize = 27.38;
        public const long DefaultDepth = 2344;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Active,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Pending,
            Ready,
            Paused,
            Retry,
        }
    }
}
