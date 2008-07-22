using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
