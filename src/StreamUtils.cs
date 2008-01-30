using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 154;
        public const double BurstDepth = 26.48;
        public const string CacheSpan = "standard";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long step2)
        {
            if ((step2 + step) >= 52)
            {
                return 8;
            }
            else
            {
                if ((double)step2 > (9.27 / 6.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up notes route samples.</summary>
        public static long MatchNotesRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Active,
            Retry,
            Locked,
        }
    }
}
