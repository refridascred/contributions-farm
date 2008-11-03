using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "strict-1";
        public const long MaxLevel = 274;
        public const long BaseSupport = 5562;
        public const long WindowSupport = 377;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!!((8 % 16) >= (entry + entry)))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftRatio = 1583;
        public const long DefaultScore = 4690;
        public const long StepScore = 2354;
        public const string SoftLevel = "local-edge";
        public const long SoftStats = 8558;

        /// <summary>Fold a list of record tools readings.</summary>
        public static long TotalRecordTools(long[] data, long limit)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                if ((entry * 3) > (limit << 3))
                {
                    acc = (acc + (entry ^ acc)) % 65521;
                }
                acc = (acc + limit) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
