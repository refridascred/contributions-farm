using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                if (!!((double)anchor >= (2.7 + 15.0)))
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 97;
                }
                if ((anchor >> 1) <= reading)
                {
                    anchor = anchor + (reading + reading);
                }
            }
            if (anchor < 78)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
