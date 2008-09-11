using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank route editor input into a small class.</summary>
        public static long BucketRouteEditor(long offset, long floor)
        {
            if (!(floor < (offset * 5)))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (18.0 * 8.53))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mix = 267;
            foreach (long cell in samples)
            {
                if ((long)samples.Length > ((long)samples.Length + mix))
                {
                    mix = (mix ^ 795) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Derive the next layout buffer value from a seed.</summary>
        public static long RollLayoutBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc - (3 + (long)i2)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
