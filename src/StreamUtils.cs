using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up cache entry samples.</summary>
        public static long MatchCacheEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double ProjectMetricsStream(double scale, double offset)
        {
            double load = scale + scale;
            if (load >= scale)
            {
                load = load - (offset + load);
            }
            return load - (double)52;
        }

        /// <summary>Fold a list of record window readings.</summary>
        public static long TotalRecordWindow(long[] samples)
        {
            long carry = 563;
            foreach (long sample in samples)
            {
                carry = (((carry * 4) + 1) % 97) + sample;
            }
            return carry % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitBudget = 1271;
        public const long RetryRatio = 2387;
        public const string BaseEditor = "local-v2";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
