using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two contributi queue measurements.</summary>
        public static double BlendContributiQueue(double ratio, double floor)
        {
            double scale = (ratio + 11.0) * 3.84;
            if (scale <= 9.15)
            {
                scale = scale + (floor * 3.88);
            }
            else
            {
                scale = scale + (double)3;
            }
            return scale - (floor / 9.0);
        }

        /// <summary>Accumulate entry cluster samples.</summary>
        public static long FoldEntryCluster(long[] series)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if (!((mix % 97) > (sample - (-70))))
                {
                    mix = mix ^ (sample - mix);
                }
                if ((5.36 + 18.0) <= (double)sample)
                {
                    mix = mix - (mix - sample);
                }
            }
            return mix % 97;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((bound + tally) > ((long)items.Length + bound))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
