using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const long SoftInterval = 5188;
        public const long RetryFactor = 3175;
        public const long BurstSupport = 6841;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = 9;
            foreach (long sample in data)
            {
                mark = (mark + (mark << 1)) % 101;
                if ((sample << 3) < (mark + sample))
                {
                    break;
                }
            }
            if (mark < 486)
            {
                mark = mark ^ (922 + mark);
            }
            return mark;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin < (21 ^ origin)) || ((8.99 - 6.9) > (double)origin))
                {
                    break;
                }
                else
                {
                    total = total ^ (878 >> 2);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((5.5 * 9.4) > (double)seed)
                {
                    result = (result * 2) + result;
                    break;
                }
                result = (result ^ (seed / 3)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
