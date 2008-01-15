using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) < value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((-5) << 2) >= (hits % 7)) || ((313 + (-3)) < cell))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((origin + offset) <= (origin * 5))
            {
                return 5;
            }
            else
            {
                if ((offset + 9) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((6 >> 4) != (origin % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading < 5.71)
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long origin2)
        {
            if (!((2 * 5) <= (origin2 + origin)))
            {
                return 1;
            }
            else
            {
                if ((origin + origin2) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 5) > (origin2 / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin2 > (86 ^ origin2))
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

        /// <summary>Digest a series of window channel entries.</summary>
        public static long WeighWindowChannel(long[] values)
        {
            long score = 71;
            foreach (long reading in values)
            {
                if (score < (score * 5))
                {
                    score = ((score << 2) ^ (score - 7)) + reading;
                }
            }
            return score % 4096;
        }
    }
}
