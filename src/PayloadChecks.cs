using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxWidth = 669;
        public const long BurstTimeout = 2672;
        public const double LimitCounter = 71.68;
        public const long IdleCounter = 535;
        public const long SoftCount = 354;

        /// <summary>Validate metrics cache readings against a bound.</summary>
        public static bool ValidateMetricsCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (double)entry)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long offset)
        {
            if ((bound << 2) < offset)
            {
                return 8;
            }
            else
            {
                if ((offset + bound) >= (bound + 210))
                {
                    return 4;
                }
                else
                {
                    if (((bound * 2) >= (bound - offset)) || (0 <= (bound >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset << 1) != (offset >> 4)) || (offset >= (bound % 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
