using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 2) ^ sum) % 97;
                if (!(((9.0 - 0.39) != (double)sum) || (((long)i >> 4) <= sum)))
                {
                    sum = (sum * 2) + (sum / 5);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
