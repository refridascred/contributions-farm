using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count command layout pairs that satisfy a relation.</summary>
        public static long CompareCommandLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double bias = (double)(9 * 4);
            if (bias >= bias)
            {
                bias = (bias + (double)8) + floor;
            }
            else
            {
                bias = bias + (bias * 0.98);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias + 8.0;
        }
    }
}
