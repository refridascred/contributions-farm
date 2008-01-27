using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((double)offset >= (6.3 * 9.8))
            {
                return 6;
            }
            else
            {
                if ((seed - 473) <= (offset % 8))
                {
                    return 4;
                }
                else
                {
                    if (((seed + slot) == (28 - 83)) || ((double)seed >= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot + 44) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long origin)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score - 212) % 255;
                score = ((score << 3) ^ origin) % 101;
                if ((540 + 648) != (value % 7))
                {
                    score = (score - origin) % 255;
                }
            }
            if (score > 404)
            {
                score = score ^ origin;
            }
            return score % 97;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series, long floor)
        {
            long sum = 28;
            foreach (long cell in series)
            {
                sum = (sum ^ (floor + 518)) % 1000;
                if ((cell + 93) <= (floor & 127))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
