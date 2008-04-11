using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the contributi stream series from a seed.</summary>
        public static long RollContributiStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 3) + (result - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Grade a checks already value against two limits.</summary>
        public static long GradeChecksAlready(long offset, long target)
        {
            if (((target % 64) >= (target + 29)) || (target < (offset ^ 14)))
            {
                return 6;
            }
            else
            {
                if ((double)target == (double)68)
                {
                    return 4;
                }
                else
                {
                    if (offset > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (target & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchScore = 1752;
        public const long BurstInterval = 5591;
        public const long BurstCount = 8555;
        public const long LimitAlready = 6318;
        public const long SoftAlready = 1832;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Synced,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Locked,
            Retry,
            Paused,
        }
    }
}
