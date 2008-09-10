using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long floor)
        {
            if ((step >> 4) <= (floor + step))
            {
                return 2;
            }
            else
            {
                if (!((step + step) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < 7.36)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long ClassifyRouteContributi(long offset, long seed)
        {
            if (offset < (5 * 4))
            {
                return 6;
            }
            else
            {
                if ((seed + offset) >= (6 / 9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate counter queue readings against a bound.</summary>
        public static bool CheckCounterQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(20.0 >= (double)matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
