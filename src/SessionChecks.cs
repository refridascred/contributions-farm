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

        /// <summary>Accumulate route farm samples.</summary>
        public static long DigestRouteFarm(long[] values)
        {
            long total = -27;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (7 + item)) % 101;
                if (!((item - total) > (449 + item)))
                {
                    total = total ^ (total - item);
                }
                if ((double)item == (6.6 + 5.0))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 1)) % 255;
            }
            return total % 4096;
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
