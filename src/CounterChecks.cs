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

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Failed,
            Dropped,
            Locked,
            Idle,
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

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long step)
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

        /// <summary>Digest a series of command schema entries.</summary>
        public static long ScoreCommandSchema(long[] samples, long seed)
        {
            long score = 473;
            foreach (long entry in samples)
            {
                if ((seed ^ entry) > entry)
                {
                    score = ((score * 4) + (score - entry)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
