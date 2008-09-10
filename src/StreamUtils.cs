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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((8.0 * 14.0) == (double)matches)
                {
                    matches = ((matches + 1) - datum) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
