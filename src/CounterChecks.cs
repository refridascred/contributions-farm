using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up command stats samples.</summary>
        public static long OverlapCommandStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long offset)
        {
            long slot = bound - offset;
            if ((double)slot < 5.8)
            {
                return 8;
            }
            else
            {
                if (slot <= (slot >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot / 4) == (slot - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long score = 87;
            foreach (long sample in items)
            {
                if (score > (score - score))
                {
                    score = ((score ^ (76 >> 5)) % 65521) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                if ((mark - mark) > (720 & 3))
                {
                    mark = ((mark + (8 >> 4)) % 4096) - value;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 255;
                }
            }
            if (mark > 681)
            {
                mark = ((mark << 3) ^ 7) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Scale a batch entry figure with a bias.</summary>
        public static double AdjustBatchEntry(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (ratio / 2.0)) + offset;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
