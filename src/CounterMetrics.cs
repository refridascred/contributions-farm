using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next checks notes value.</summary>
        public static double AdjustChecksNotes(double weight, double span)
        {
            double scale = span;
            if (scale < weight)
            {
                scale = scale + (weight * 18.0);
            }
            return scale + span;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every graph session entry stays within the limit.</summary>
        public static bool CheckGraphSessionBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
