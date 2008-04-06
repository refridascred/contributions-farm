using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema commits value against two limits.</summary>
        public static long GradeSchemaCommits(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (((offset + offset2) < (edge / 7)) && (offset >= (edge ^ offset2)))
            {
                return 3;
            }
            else
            {
                if ((edge + 617) <= offset2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((step >> 4) != (cell + 873)) && ((hits >= (72 - hits)) && ((3 % 100) < cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta ^ delta) <= (3 + floor))
            {
                return 5;
            }
            else
            {
                if ((floor % 12) <= floor)
                {
                    return 8;
                }
                else
                {
                    if ((double)delta < (9.0 * 9.8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta + delta) <= (floor << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
