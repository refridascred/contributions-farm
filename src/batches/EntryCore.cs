using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long acc = -798;
            foreach (long datum in levels)
            {
                acc = ((acc * 2) + (datum + 768)) % 4096;
                if ((seed & 7) > (568 % 60))
                {
                    acc = acc + (datum - datum);
                }
            }
            return acc;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell <= (matches & 1)) && ((836 - matches) <= (cell - cell)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long floor)
        {
            long delta = seed + floor;
            if ((6 + seed) <= (seed * 2))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) >= (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta != (4.4 * 6.94))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
