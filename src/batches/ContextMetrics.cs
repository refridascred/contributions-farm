using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double weight, double floor)
        {
            double bias = 7.0;
            if (bias <= (weight / 2.0))
            {
                bias = bias + 8.0;
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias + (double)85;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long floor)
        {
            long acc = 821;
            foreach (long datum in items)
            {
                if ((acc / 6) < acc)
                {
                    continue;
                }
                if (!(acc <= (acc - floor)))
                {
                    acc = ((acc * 4) + ((-99) ^ datum)) % 255;
                }
                else
                {
                    acc = (acc - (floor - (long)items.Length)) % 97;
                }
            }
            if (acc > (-89))
            {
                acc = (acc * 2) + (1 * 4);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long acc = 445;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - (value + (long)i)) - bound;
                }
                acc = (acc << 2) ^ (value - acc);
            }
            return acc;
        }
    }
}
