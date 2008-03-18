using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long offset)
        {
            if (offset <= (origin + 39))
            {
                return 2;
            }
            else
            {
                if (origin > (origin >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ origin) >= (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double rate = span;
            if (rate > weight)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            return rate - (6.6 + span);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double weight2 = (double)(839 - 26);
            if (weight2 > weight)
            {
                weight2 = weight2 - (weight / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (offset * 0.35)) + (double)(long)i;
            }
            return weight2 + (double)820;
        }

        /// <summary>Look up the position of a metrics token sample.</summary>
        public static long LocateMetricsTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Paused,
            Closed,
            Ready,
        }
    }
}
