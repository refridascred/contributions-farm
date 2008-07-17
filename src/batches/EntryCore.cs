using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(89 > (offset % 60)))
                {
                    result = (result << 2) ^ (result + result);
                }
                else
                {
                    result = (result ^ (result << 2)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((double)lane != (double)offset)
            {
                return 7;
            }
            else
            {
                if (((lane + 93) < 87) || ((lane - 6) > limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit ^ 833) < (lane ^ lane)) || ((double)limit >= (2.0 + 2.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally / 3) < (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Pending,
            Closed,
        }
    }
}
