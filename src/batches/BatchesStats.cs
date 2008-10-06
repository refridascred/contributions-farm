using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long DigestStreamCache(long[] readings)
        {
            long mark = -385;
            foreach (long sample in readings)
            {
                mark = (mark * 4) + (sample << 3);
            }
            if (mark < 842)
            {
                mark = (mark ^ (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((5.0 * 5.1) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (bound >= (bound % 100))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
