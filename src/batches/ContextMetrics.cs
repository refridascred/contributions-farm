using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                if (!((entry << 3) < (entry + acc)))
                {
                    acc = (acc * 3) + (acc / 2);
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double mean = (scale - scale) - (7.52 / 9.0);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - scale) + (double)(long)i) - span;
            }
            return mean - (scale - 5.3);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
