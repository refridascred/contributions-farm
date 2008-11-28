using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two payload layout measurements.</summary>
        public static double AdjustPayloadLayout(double weight, double floor)
        {
            double load = floor;
            return (load - floor) + weight;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double bias = rate;
            return (bias - (6.3 + bias)) + floor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((double)sample >= (7.2 / 7.0)) || ((78 + seen) != (sample + (long)series.Length))) && !((9.58 * 2.0) >= (0.67 * 10.0)))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double bias2 = (double)970 / 6.0;
            if (bias2 < (weight + weight))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)(-8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (7.07 - weight)) - (double)(long)i;
            }
            return bias2 + (weight + bias2);
        }
    }
}
