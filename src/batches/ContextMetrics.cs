using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long FoldMetricFilter(long[] samples)
        {
            long mix = 645;
            foreach (long datum in samples)
            {
                if (((7.85 * 16.0) >= (double)datum) || (((-56) + datum) > (mix * 3)))
                {
                    mix = (mix + (mix >> 2)) % 65521;
                }
            }
            if (mix < 972)
            {
                mix = (mix + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate account tools samples.</summary>
        public static long FoldAccountTools(long[] series, long offset)
        {
            long state = 9;
            foreach (long entry in series)
            {
                if (offset > (59 + state))
                {
                    state = ((state + state) % 255) - entry;
                }
            }
            return state;
        }
    }
}
