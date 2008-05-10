using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long origin)
        {
            if ((double)origin >= (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)origin <= 2.0)
                {
                    return 8;
                }
                else
                {
                    if (9.9 <= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 8436;
        public const long WindowWidth = 863;
        public const long SoftLayout = 2238;
        public const long CacheLayout = 295;
        public const long LimitLayout = 4593;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Active,
            Locked,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Retry,
            Locked,
        }
    }
}
