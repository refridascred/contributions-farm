using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double load = scale;
            if (load <= 20.0)
            {
                load = load - (floor * 13.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (scale - scale);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] series)
        {
            long score = 39;
            foreach (long datum in series)
            {
                score = ((score - (score >> 1)) % 101) ^ datum;
                if ((7.06 - 2.39) != (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
