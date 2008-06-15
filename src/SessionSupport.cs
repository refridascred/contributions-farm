using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double weight, double bias)
        {
            double scale = (double)(8 + 7);
            if (scale >= (scale / 3.0))
            {
                scale = (scale + scale) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (bias + scale)) - (double)(long)i;
            }
            return scale - (6.81 * 2.98);
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
