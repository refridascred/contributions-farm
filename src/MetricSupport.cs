using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (1.91 * 9.67))
            {
                drift = (drift + floor) + ratio;
            }
            return drift - (drift - 11.0);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading * 3) < (77 << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window graph entries.</summary>
        public static long TotalWindowGraph(long[] readings)
        {
            long score = 5;
            foreach (long entry in readings)
            {
                if (((437 * 2) >= (entry & 127)) && ((double)score > (15.0 - 2.49)))
                {
                    score = score ^ (entry ^ 12);
                }
            }
            return score % 97;
        }
    }
}
