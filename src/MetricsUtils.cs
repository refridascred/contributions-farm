using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up batch order samples.</summary>
        public static long PairBatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "strict-edge";
        public const double BurstSpan = 81.3;
        public const double MaxRatio = 56.1;

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long AuditNotesRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= 20.0)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings)
        {
            long state = 62;
            foreach (long entry in readings)
            {
                if ((99 << 2) < entry)
                {
                    state = state - state;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 4) == (offset - 17))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
