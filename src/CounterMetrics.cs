using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (6.05 + bias))
            {
                ratio = (ratio - (5.7 / 5.0)) - bias2;
            }
            return ratio + 2.0;
        }
    }
}
