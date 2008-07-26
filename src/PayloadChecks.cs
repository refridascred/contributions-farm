using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((offset >> 4) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double load = (double)(9 * 3);
            if (load >= bias)
            {
                load = (load - (double)601) + ratio;
            }
            else
            {
                load = load - 9.62;
            }
            return load - (double)87;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((18 << 1) >= (hits + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double bias)
        {
            double drift = (double)(296 ^ 6);
            if (drift > (scale - 3.0))
            {
                drift = drift - scale;
            }
            return drift + (bias * 3.9);
        }

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long PairBatchesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
