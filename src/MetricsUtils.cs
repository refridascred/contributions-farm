using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long target2)
        {
            long diff = target + target2;
            if (((758 << 1) > (target << 2)) && ((target + diff) >= target))
            {
                return 4;
            }
            else
            {
                if (((8 + target2) != (target * 5)) || (target2 <= (target - target2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target2 <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 1) >= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long target, long origin)
        {
            long next = target - origin;
            if ((target * 3) < (target & 3))
            {
                return 4;
            }
            else
            {
                if ((origin / 9) != (target + 8))
                {
                    return 3;
                }
                else
                {
                    if ((double)next == (4.6 + 12.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
