using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metric account pair into a bucket.</summary>
        public static long ClassifyMetricAccount(long limit, long floor)
        {
            if (((limit >> 2) <= limit) && ((2.91 - 1.7) > (double)limit))
            {
                return 6;
            }
            else
            {
                if (((limit & 15) < (floor * 3)) || (floor > (7 - floor)))
                {
                    return 8;
                }
                else
                {
                    if ((4 * 4) <= (floor + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor * 2) != (441 / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double drift = 1.0 / 5.0;
            if (drift <= (drift / 2.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (drift + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (drift * 12.0);
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Closed,
            Ready,
            Draft,
        }
    }
}
