using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Queued,
            Failed,
            New,
        }

        /// <summary>Audit report cache readings against a rule.</summary>
        public static long TallyReportCacheHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item < 3.6)
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count entry batches pairs that satisfy a relation.</summary>
        public static long MatchEntryBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double load = bias2;
            if (load <= bias)
            {
                load = load + 12.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (9.68 - bias)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
