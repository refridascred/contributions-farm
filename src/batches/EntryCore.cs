using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up batch stats samples.</summary>
        public static long OverlapBatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics batches counter forward.</summary>
        public static long IterateMetricsBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                long gap = (long)i + (anchor & 63);
                if (((-41) <= gap) || ((seed + seed) > (gap - gap)))
                {
                    anchor = ((anchor * 4) + (anchor - seed)) % 1000;
                    anchor = anchor - (gap << 1);
                }
                if ((double)anchor != (2.01 * 6.64))
                {
                    anchor = anchor ^ (seed & 31);
                    gap = gap + gap;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double bias = (double)(-1);
            if (bias >= (bias + bias))
            {
                bias = ((bias + (bias / 3.0)) + weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 20.0) + (double)(long)i;
            }
            return bias + 8.0;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
