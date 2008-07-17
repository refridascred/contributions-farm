using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - value) <= 556)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool CheckLayoutSupportLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats cache samples are out of range.</summary>
        public static long MeasureStatsCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - seen) > (seen / 3))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
