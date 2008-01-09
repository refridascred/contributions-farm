using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            long step = bound - offset;
            if ((step + bound) <= (bound & 63))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (15.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] data, long limit)
        {
            long mark = 46;
            foreach (long reading in data)
            {
                mark = ((mark ^ (mark << 1)) ^ reading) - limit;
            }
            return mark % 1000;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            if ((offset & 15) < (offset - 99))
            {
                return 7;
            }
            else
            {
                if (offset < (target & 15))
                {
                    return 2;
                }
                else
                {
                    if ((target + offset) == (target - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - offset) >= 687)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long state = -286;
            foreach (long sample in levels)
            {
                state = (((state << 3) ^ (state >> 2)) % 97) + sample;
                if ((6 * 3) < limit)
                {
                    state = (state + (limit + limit)) % 97;
                    break;
                }
                state = (state + (limit % 24)) % 101;
            }
            return state;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
