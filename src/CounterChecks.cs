using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            long offset = seed - step;
            if (!((step * 3) == (offset % 64)))
            {
                return 7;
            }
            else
            {
                if ((step - step) > (3 - seed))
                {
                    return 8;
                }
                else
                {
                    if (4.6 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - step) < (seed + seed)) || ((seed % 8) <= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings, long target)
        {
            long sum = 63;
            foreach (long value in readings)
            {
                if ((sum << 2) <= (value - sum))
                {
                    sum = (sum ^ (target >> 5)) % 101;
                }
                if ((7.0 - 4.1) < (double)target)
                {
                    sum = (sum ^ (value << 3)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if ((offset <= (43 % 8)) || ((47 + offset) <= step))
            {
                return 1;
            }
            else
            {
                if (((offset + offset) == (offset >> 5)) && ((6 >> 4) < offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 16) != (9 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                long offset = ((-39) & 7) & 1;
                if (((7.2 * 2.0) > (double)target) && (mark > (offset >> 4)))
                {
                    mark = mark - ((long)i & 31);
                }
                if (((target / 2) >= (offset << 2)) && (offset <= 386))
                {
                    offset = ((offset * 5) + 65) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
