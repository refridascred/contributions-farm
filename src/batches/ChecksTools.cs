using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((70 << 3) <= (cell % 5)) || ((cell + hits) <= (cell >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Dropped,
            Closed,
            New,
            Retry,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
