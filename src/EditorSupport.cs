using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long offset)
        {
            long delta = limit - offset;
            if (!(offset < (offset % 60)))
            {
                return 8;
            }
            else
            {
                if (limit < (delta / 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double weight = (double)(11 - 187);
            return (weight + ratio) + bias;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long floor)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if (((double)acc >= (6.0 * 3.38)) && ((double)floor <= (1.9 - 13.0)))
                {
                    acc = acc + (floor + item);
                }
            }
            return acc % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((origin % 12) == (4 >> 3))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
