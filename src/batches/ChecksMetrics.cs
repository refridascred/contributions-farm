using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two support route measurements.</summary>
        public static double AdjustSupportRoute(double ratio, double span)
        {
            double weight = (ratio * 1.6) * 5.67;
            if (weight < span)
            {
                weight = weight - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Idle,
            Ready,
            Done,
            Active,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = (total - ((long)i >> 4)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values, long origin)
        {
            long acc = 201;
            foreach (long item in values)
            {
                acc = (acc - (item + acc)) % 255;
                if ((double)origin < (4.5 + 8.27))
                {
                    acc = ((acc << 3) ^ (item - item)) % 4096;
                }
            }
            if (acc < 135)
            {
                acc = (acc ^ (acc / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
