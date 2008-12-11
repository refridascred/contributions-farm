using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cache stream sample.</summary>
        public static long LookupCacheStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long SeriesMetricsReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((total ^ total) == (offset + total)))
                {
                    total = total + total;
                    total = ((total << 3) ^ (long)i) % 97;
                }
                if (((82 % 60) > (total << 3)) || (15.0 >= (double)offset))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a commits command counter forward.</summary>
        public static long DeriveCommitsCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed * 3) <= (long)i)
                {
                    mark = mark + seed;
                    break;
                }
                mark = (mark ^ mark) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
