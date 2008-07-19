using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of order batches entries.</summary>
        public static long TallyOrderBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                if ((entry >> 4) < (34 / 2))
                {
                    result = ((result ^ result) % 1000) - origin;
                }
                if ((result + entry) < (83 * 4))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (5 + target)) % 4096;
                mark = (mark * 2) + ((long)i >> 3);
                if ((target - 465) >= mark)
                {
                    mark = ((mark * 3) + (target * 2)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
