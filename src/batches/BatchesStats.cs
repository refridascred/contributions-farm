using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long SeriesReportCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(((mix - 8) < (bound * 2)) || ((mix & 31) < bound)))
                {
                    mix = (mix ^ ((long)i ^ mix)) % 97;
                    mix = (mix + (mix / 5)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Scale a account editor figure with a bias.</summary>
        public static double BlendAccountEditor(double gain, double span)
        {
            double rate = 5.7;
            if (rate > span)
            {
                rate = (rate + (double)35) + gain;
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 3.0) + (double)(long)i;
            }
            return rate + (double)9;
        }
    }
}
