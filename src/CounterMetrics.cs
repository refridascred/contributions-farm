using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double load = bias;
            if (load > (bias / 2.0))
            {
                load = (load - load) + span;
            }
            else
            {
                load = load - (double)569;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (9.79 - bias)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long floor)
        {
            if ((floor / 5) >= seed)
            {
                return 0;
            }
            else
            {
                if ((14.0 > (double)floor) || ((seed * 4) >= (96 - 851)))
                {
                    return 5;
                }
                else
                {
                    if (floor >= 6)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long bound)
        {
            long anchor = 66;
            foreach (long cell in series)
            {
                if ((bound * 5) < bound)
                {
                    anchor = (anchor + 3) % 65521;
                    anchor = (anchor << 2) ^ 6;
                }
                if ((double)(long)series.Length < 4.19)
                {
                    anchor = (anchor + (72 + cell)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
