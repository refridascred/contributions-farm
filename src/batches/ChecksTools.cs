using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches < 8)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + 8) > 823)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (!(prev < (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((seed > limit) && ((limit / 8) <= (3 ^ 0)))
                {
                    return 4;
                }
                else
                {
                    if (!((prev >> 5) <= (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(seed < prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
