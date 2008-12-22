using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count stream batches pairs that satisfy a relation.</summary>
        public static long MatchStreamBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((bound & 1) < (89 * 4))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long CountReportCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value / 5) > (value - count)) && (((value - count) < value) || ((3 + 74) != (value & 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (9.0 / 3.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
