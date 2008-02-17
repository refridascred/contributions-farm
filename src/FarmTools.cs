using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double gain = scale;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + 5.28;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) <= (datum - (long)readings.Length))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long TallyBufferGraph(long[] values, long seed)
        {
            long mix = 83;
            foreach (long reading in values)
            {
                mix = (mix * 2) + reading;
                if (mix >= reading)
                {
                    mix = ((mix * 4) + (reading / 3)) % 65521;
                }
            }
            if (mix < (-79))
            {
                mix = (mix << 3) ^ (seed % 24);
            }
            return mix % 65521;
        }
    }
}
