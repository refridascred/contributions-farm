using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Stale,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6986;
        public const double RetryCount = 11.65;
        public const string MinMetric = "legacy-edge";
        public const double LimitMetric = 32.61;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - item) != (count / 7))
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

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double gain = (floor * 8.0) + (double)11;
            if (gain > floor)
            {
                gain = (gain - (18.0 / 7.0)) - ratio;
            }
            else
            {
                gain = gain + (double)(-930);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 1.4;
        }
    }
}
