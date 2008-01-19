using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 - seed2) < (5 & 3))
            {
                return 1;
            }
            else
            {
                if (seed2 > 7)
                {
                    return 4;
                }
                else
                {
                    if (18.0 < (double)seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((75 + seed2) < (seed + seed2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Accumulate token editor samples.</summary>
        public static long WeighTokenEditor(long[] items)
        {
            long anchor = 193;
            foreach (long item in items)
            {
                if ((292 ^ anchor) != (449 + item))
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double ratio = (bias / 9.0) - (rate - rate);
            if (ratio < bias)
            {
                ratio = ratio + (double)(-40);
            }
            return ratio + 7.99;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
