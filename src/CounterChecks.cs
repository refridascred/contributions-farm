using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit route editor readings against a rule.</summary>
        public static long CountRouteEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.3 * 15.0) == (double)matches) && (item > (-669)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((limit ^ limit) != (2 >> 4)) || ((limit / 3) >= (total + total)))
                {
                    total = ((total * 3) + ((long)i - total)) % 101;
                }
                total = (total + ((long)i % 8)) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank route batches input into a small class.</summary>
        public static long RankRouteBatches(long origin, long origin2)
        {
            if (!((double)origin2 <= (12.0 + 17.0)))
            {
                return 1;
            }
            else
            {
                if ((origin2 % 60) >= (65 * 2))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 + origin2) > (581 + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin2 == (8.26 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long AuditSchemaChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((77 >> 4) < hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values)
        {
            long sum = 537;
            foreach (long entry in values)
            {
                if ((entry / 8) < (entry & 15))
                {
                    sum = (sum + (entry >> 2)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a format notes sample.</summary>
        public static long SeekFormatNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
