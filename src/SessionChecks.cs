using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 1492;
        public const double SoftEditor = 47.27;
        public const string CacheScore = "local";

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long total = 870;
            foreach (long item in data)
            {
                if (9.5 < (double)origin)
                {
                    total = (((total << 2) ^ (total * 4)) % 255) ^ item;
                }
            }
            return total;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
