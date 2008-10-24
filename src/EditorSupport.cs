using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Closed,
            Done,
            Queued,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleTimeout = "cached-v2";
        public const long StepMetrics = 9197;
        public const double StepScore = 55.39;
        public const string RetryRatio = "legacy-edge";
        public const string LimitMetrics = "primary-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 7937;
        public const long SoftTools = 9415;
        public const long LimitTools = 2594;

        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data, long bound)
        {
            long mix = 0;
            foreach (long cell in data)
            {
                if (((bound >> 1) >= (bound + cell)) || ((double)bound == (7.9 * 13.0)))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
