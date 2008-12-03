using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((floor >> 1) > ((long)i ^ floor))
                {
                    state = (state << 3) ^ ((long)i >> 1);
                    continue;
                }
                else
                {
                    state = state - (floor >> 2);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a report batches reading.</summary>
        public static double ProjectReportBatches(double rate, double floor)
        {
            double load = floor;
            if (load > 9.2)
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)4) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)53)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + (ratio * 5.6);
            }
            return rate + 5.0;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count account metric pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
