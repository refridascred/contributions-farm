using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double drift = (weight - 1.82) + 18.0;
            if (drift < span)
            {
                drift = drift - (double)154;
            }
            return drift + (weight / 8.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long limit)
        {
            long sum = -72;
            foreach (long sample in data)
            {
                if ((sum << 1) >= (sum + limit))
                {
                    sum = (((sum * 3) + (sum << 1)) % 101) ^ sample;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if (((long)data.Length / 5) != (sum >> 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((item + item) <= (item * 5)) || (seen < (seen + item))) || !((seen & 255) < (item ^ item)))
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
