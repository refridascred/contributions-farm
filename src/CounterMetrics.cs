using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long TallyEditorBatchesOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits >= ((-369) ^ offset))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (carry << 2)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 5; i++)
            {
                scale2 = ((scale2 - 5.74) + (double)(long)i) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Flag { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
