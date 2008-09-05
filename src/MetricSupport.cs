using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (tally << 2))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double span)
        {
            double bias = (1.0 / 7.0) + (double)44;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + 9.29) + (double)(long)i) - span;
            }
            return bias - ratio;
        }

        /// <summary>Accumulate editor order samples.</summary>
        public static long WeighEditorOrder(long[] levels, long bound)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                if (datum < 63)
                {
                    anchor = ((anchor * 5) + datum) % 65521;
                }
            }
            if (anchor < 165)
            {
                anchor = anchor + (bound ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
