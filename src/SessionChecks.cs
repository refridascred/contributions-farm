using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine batches metrics values into a single score.</summary>
        public static long TotalBatchesMetrics(long[] readings, long origin)
        {
            long sum = 914;
            foreach (long value in readings)
            {
                if (((sum - value) != (578 / 8)) || ((value & 7) <= sum))
                {
                    sum = sum + origin;
                }
                else
                {
                    sum = sum + (sum + value);
                }
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long acc = 555;
            foreach (long value in series)
            {
                if ((8.1 - 9.66) < (double)value)
                {
                    acc = (acc - (step + value)) % 1000;
                }
                else
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
