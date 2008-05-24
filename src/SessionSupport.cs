using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Stale,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long seed)
        {
            long span = bound - seed;
            if ((3.5 - 6.99) != (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((span + seed) < span))
                {
                    return 6;
                }
                else
                {
                    if (((648 / 7) > span) || (bound >= seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((span >> 3) >= (682 ^ seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 11.14;
        public const long MinFactor = 8499;
        public const long WindowScore = 6414;
    }
}
