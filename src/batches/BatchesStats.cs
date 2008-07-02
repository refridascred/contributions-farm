using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long mix = -55;
            foreach (long datum in readings)
            {
                mix = (mix + (origin & 127)) + datum;
                if (mix >= (origin - origin))
                {
                    mix = (mix ^ (origin + mix)) % 101;
                }
                else
                {
                    mix = (mix ^ (origin + origin)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every metric batch entry stays within the limit.</summary>
        public static bool GuardMetricBatchBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks cluster values into a single score.</summary>
        public static long ScoreChecksCluster(long[] data)
        {
            long anchor = 22;
            foreach (long item in data)
            {
                anchor = (anchor * 3) + (14 - anchor);
                anchor = (anchor * 2) + item;
            }
            return anchor;
        }
    }
}
