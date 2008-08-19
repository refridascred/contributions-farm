using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the schema metric entries that pass the check.</summary>
        public static long AuditSchemaMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((6.59 * 0.2) == (double)matches) || ((sample > (matches << 3)) || (366 < sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long target)
        {
            long lane = step ^ target;
            if ((903 % 64) < (target - 32))
            {
                return 1;
            }
            else
            {
                if (((446 + 52) > lane) || (19.0 <= (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) > 82)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 + 3.7) != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading > ((long)samples.Length - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
