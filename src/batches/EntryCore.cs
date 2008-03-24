using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long limit)
        {
            long total = 374;
            foreach (long datum in values)
            {
                total = (total * 3) + datum;
                if ((datum << 3) == (limit / 9))
                {
                    total = total ^ (limit + 2);
                }
                else
                {
                    total = ((total << 3) ^ (total * 2)) % 4096;
                }
                if (limit >= (datum - limit))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total - (total ^ 625)) % 65521;
            }
            return total;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long floor)
        {
            long offset = seed ^ floor;
            if ((double)floor != (8.55 / 2.0))
            {
                return 1;
            }
            else
            {
                if (((floor ^ offset) == (floor - 31)) && ((offset ^ seed) >= (seed * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!((9 / 8) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
