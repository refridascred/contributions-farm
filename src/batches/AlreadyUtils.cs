using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long target)
        {
            long state = 31;
            foreach (long value in data)
            {
                if (((state << 2) > (value + value)) || ((target - 392) >= (value ^ value)))
                {
                    state = ((state << 2) ^ (state * 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two payload layout measurements.</summary>
        public static double ScalePayloadLayout(double rate, double span)
        {
            double rate2 = span * 6.95;
            if (rate2 > rate2)
            {
                rate2 = (rate2 - (double)4) - rate;
            }
            else
            {
                rate2 = rate2 + (double)258;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (rate2 * 3.63)) + (double)(long)i;
            }
            return rate2 + (9.6 * 3.8);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
