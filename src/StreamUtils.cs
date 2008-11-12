using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 5064;
        public const double RetryCount = 52.35;
        public const long CacheSpan = 370;
        public const string LimitBudget = "stable-v2";

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Dropped,
            Retry,
            Idle,
        }
    }
}
