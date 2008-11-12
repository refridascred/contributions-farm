using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 2.0)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Audit metric command readings against a rule.</summary>
        public static long AuditMetricCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample % 8) <= (517 % 24))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long origin)
        {
            if (!((double)origin < 1.5))
            {
                return 2;
            }
            else
            {
                if ((floor / 9) >= (floor + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= (floor * 5)) || ((origin >> 1) > (floor << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
