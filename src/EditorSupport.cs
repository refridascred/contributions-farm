using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count > (count + count))
                {
                    count = ((count + 3) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitCount = 6299;
        public const double BaseMetrics = 44.67;
        public const long LimitMetrics = 4940;
        public const double WindowDepth = 15.12;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long SortCommitsMetrics(long origin, long seed)
        {
            if (origin >= ((-1) ^ seed))
            {
                return 1;
            }
            else
            {
                if ((origin ^ seed) < origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin / 6) <= (seed % 100))
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
