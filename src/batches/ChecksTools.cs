using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) != (datum + datum))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
