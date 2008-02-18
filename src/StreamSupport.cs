using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (weight + ratio))
            {
                ratio = ratio + 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)905) + (double)(long)i;
            }
            return ratio + (2.0 + bias);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if (state <= (limit & 255))
                {
                    state = (state << 2) ^ ((long)i * 5);
                }
                if (!((state << 2) > 697))
                {
                    state = (state + (state / 6)) % 65521;
                }
                else
                {
                    state = state - 531;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
