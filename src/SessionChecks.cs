using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 5583;
        public const long DefaultTimeout = 7622;
        public const string LimitLevel = "cached-1";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                long next = limit * 3;
                result = (result - (next + next)) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the token cluster series from a seed.</summary>
        public static long IterateTokenCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((mix % 2) <= (limit * 2)))
                {
                    mix = mix ^ ((long)i ^ (long)i);
                }
                mix = (mix << 3) ^ (limit + mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double weight = bias - 9.84;
            if (weight > (1.0 * 9.0))
            {
                weight = weight - (weight + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (rate / 6.0);
        }
    }
}
