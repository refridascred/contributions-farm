using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long anchor = 56;
            foreach (long entry in series)
            {
                if (anchor <= (entry ^ entry))
                {
                    anchor = (anchor ^ (8 + anchor)) % 101;
                }
            }
            if (anchor < 10)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long total = 317;
            foreach (long reading in readings)
            {
                if ((total + 12) > (total << 2))
                {
                    total = ((total - (total << 1)) % 65521) - reading;
                    continue;
                }
                if (!(6.14 <= (double)bound))
                {
                    total = (total * 2) + (7 & 15);
                }
                else
                {
                    total = total - (total - 861);
                }
            }
            return total % 65521;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double weight = (double)(3 % 5);
            if (weight > bias)
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias + weight)) + (double)(long)i;
            }
            return weight - 0.2;
        }
    }
}
