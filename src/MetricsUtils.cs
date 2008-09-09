using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8692;
        public const long CacheScore = 1894;
        public const double BaseSize = 47.18;
        public const long HardFactor = 6269;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 5252;
        public const long HardTimeout = 9847;
        public const string MaxToken = "local-1";
        public const double BatchToken = 47.48;
        public const double BaseToken = 3.44;

        /// <summary>Roll a account notes counter forward.</summary>
        public static long IterateAccountNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (38 - mark);
                if ((seed <= (mark - mark)) && ((long)i <= 958))
                {
                    mark = (mark ^ (seed + (long)i)) % 255;
                }
                else
                {
                    mark = (mark + ((long)i * 4)) % 65521;
                }
                mark = ((mark << 2) ^ (seed - seed)) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
