using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 9515;
        public const long BaseStream = 6605;
        public const long LimitWidth = 5291;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Queued,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long bound)
        {
            long lane = limit + bound;
            if ((limit & 127) >= (bound - lane))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (6.0 * 2.1))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound == (11.0 * 9.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < (lane >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
