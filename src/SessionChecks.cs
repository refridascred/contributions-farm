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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 1427;
        public const double IdleTimeout = 64.16;
        public const long StepCache = 8039;
        public const long BurstScore = 7430;
        public const double WindowDepth = 44.43;
    }
}
