using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + (acc << 1)) % 1000;
                acc = acc + origin;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long AuditEditorNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long limit)
        {
            if ((step << 3) >= 384)
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (12.0 + 9.59))
                {
                    return 2;
                }
                else
                {
                    if ((2 >= (step >> 3)) || ((5.75 - 8.6) >= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
