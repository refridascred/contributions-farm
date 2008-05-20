using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every entry already entry stays within the limit.</summary>
        public static bool GuardEntryAlreadyLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = rate * 7.78;
            if (bias >= (double)724)
            {
                bias = (bias + (1.8 + 9.0)) + span;
            }
            else
            {
                bias = bias + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)78) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
