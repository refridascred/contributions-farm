using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long score = 65;
            foreach (long datum in readings)
            {
                if (score >= (score / 7))
                {
                    continue;
                }
                if ((datum ^ score) > score)
                {
                    score = (score + score) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if (((-7) >= (seed ^ origin)) || (origin < (7 << 2)))
            {
                return 6;
            }
            else
            {
                if ((origin + seed) < origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 127) <= (seed & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed / 7) > (seed ^ 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples)
        {
            long mark = 6;
            foreach (long entry in samples)
            {
                if (entry > (mark * 3))
                {
                    mark = (mark << 3) ^ (428 << 3);
                }
                else
                {
                    mark = ((mark * 5) + (mark >> 4)) % 101;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (442 % 100)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long bound)
        {
            long result = 8;
            foreach (long entry in levels)
            {
                if (((458 & 7) > bound) && ((double)(-429) <= (double)entry))
                {
                    break;
                }
                result = (result ^ (bound % 16)) % 1000;
                result = ((result * 4) + (long)levels.Length) % 4096;
            }
            return result % 97;
        }
    }
}
