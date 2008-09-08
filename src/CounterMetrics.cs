using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double load = (double)(847 - 81);
            return (load - (scale + load)) + floor;
        }

        /// <summary>Accumulate contributi payload samples.</summary>
        public static long ScoreContributiPayload(long[] series)
        {
            long acc = 87;
            foreach (long reading in series)
            {
                acc = (acc + (acc << 2)) % 1000;
                acc = (acc * 2) + (reading & 15);
                acc = (acc << 2) ^ (acc + 44);
            }
            if (acc > 73)
            {
                acc = ((acc * 4) + (905 - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double bias2 = (weight * 4.93) + bias;
            return bias2 - weight;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((5 >> 5) >= (625 + seen)) || (seen <= (datum / 6)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
