using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "primary-v2";
        public const long WindowTimeout = 8864;
        public const string DefaultFactor = "fallback";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + (-520)) <= ((-670) - count)) || ((value + count) < (968 - 57)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Queued,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
