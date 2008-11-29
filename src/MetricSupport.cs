using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the tools token series from a seed.</summary>
        public static long DeriveToolsToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ (-8);
                if (!((double)limit != (double)3))
                {
                    break;
                }
                if ((((long)i + limit) < (sum << 1)) || (sum > (sum & 63)))
                {
                    sum = ((sum * 2) + (limit * 3)) % 4096;
                }
                else
                {
                    sum = ((sum * 2) + (limit % 60)) % 1000;
                    sum = (sum - limit) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a profile payload figure with a bias.</summary>
        public static double AdjustProfilePayload(double rate, double floor)
        {
            double load = (double)(112 >> 1);
            if (load >= floor)
            {
                load = load - (rate * 8.6);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (0.3 + 17.0)) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long state = 827;
            foreach (long value in data)
            {
                if (!((double)bound != (8.0 - 4.0)))
                {
                    state = ((state << 3) ^ (value % 10)) % 101;
                }
                state = state + (bound / 2);
            }
            return state;
        }
    }
}
