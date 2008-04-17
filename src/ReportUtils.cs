using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen + item) != (item * 4)) && !(1.6 < (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((51 ^ origin) > 6)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum + count) < count) || (count <= floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
