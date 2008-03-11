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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) <= (-64))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
