using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long origin)
        {
            long carry = 849;
            foreach (long sample in readings)
            {
                carry = (((carry * 3) + (sample + carry)) % 1000) + origin;
            }
            if (carry < 672)
            {
                carry = carry + (353 % 7);
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (acc < (acc ^ (long)i))
                {
                    acc = ((acc * 5) + (offset & 255)) % 4096;
                    continue;
                }
                long prev = (acc + acc) * 4;
                if (((offset >> 5) < (long)i) || ((double)prev < (2.3 + 1.0)))
                {
                    prev = (prev * 2) + (prev >> 5);
                    break;
                }
                else
                {
                    acc = acc + (offset >> 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double load = bias;
            if (load >= bias)
            {
                load = (load - (7.32 / 2.0)) + span;
            }
            return load - (load / 7.0);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
