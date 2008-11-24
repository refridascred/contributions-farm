using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 3) ^ (floor + floor)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long offset)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                if (entry > (entry + (long)levels.Length))
                {
                    acc = (acc * 2) + offset;
                }
            }
            return acc;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double scale = (1.81 * 20.0) + (double)4;
            if (scale >= (double)451)
            {
                scale = ((scale - (double)7) + bias) - floor;
            }
            else
            {
                scale = scale + (scale / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (15.0 * 9.0)) + (double)(long)i;
            }
            return scale + 15.0;
        }

        /// <summary>Combine report batches values into a single score.</summary>
        public static long DigestReportBatches(long[] items)
        {
            long sum = 431;
            foreach (long reading in items)
            {
                if (!((9.0 * 7.74) <= (double)reading))
                {
                    sum = (sum ^ reading) % 4096;
                }
            }
            if (sum > 38)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
