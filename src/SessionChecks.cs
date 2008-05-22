using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Check that every commits counter entry stays within the limit.</summary>
        public static bool VerifyCommitsCounterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Draft,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long limit)
        {
            long bound = offset - limit;
            if (bound <= (offset + 60))
            {
                return 7;
            }
            else
            {
                if (((bound / 3) >= limit) && ((8 << 1) < offset))
                {
                    return 4;
                }
                else
                {
                    if ((29 / 9) < (bound * 5))
                    {
                        return 8;
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
