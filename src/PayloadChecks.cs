using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (8.0 >= (double)hits)
                {
                    hits = ((hits + 3) + reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer format input into a small class.</summary>
        public static long GradeBufferFormat(long step, long step2)
        {
            if ((step ^ step2) >= (96 - 3))
            {
                return 1;
            }
            else
            {
                if ((16.0 / 6.0) >= (double)step2)
                {
                    return 5;
                }
                else
                {
                    if ((step2 + step2) <= step2)
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

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Closed,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Stale,
            Draft,
            Locked,
        }
    }
}
