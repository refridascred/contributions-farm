using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long MeasureContributiFormatHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (matches + bound))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi format value from a seed.</summary>
        public static long RollContributiFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - ((-63) + mark)) % 65521;
                mark = (mark ^ (mark / 4)) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a graph record pair into a bucket.</summary>
        public static long RankGraphRecord(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((8.0 + 4.3) == (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!(5.2 >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (double)50)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.3 + 3.3) > (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
