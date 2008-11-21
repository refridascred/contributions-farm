using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first format checks entry that matches the target.</summary>
        public static long LookupFormatChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCount = "legacy-1";
        public const string BaseFactor = "primary";
        public const long BurstCache = 3233;
        public const string MinSpan = "standard-edge";
        public const long DefaultCount = 7631;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
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
    }
}
