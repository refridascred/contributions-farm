using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheSpan = 8166;
        public const double MaxDepth = 88.3;
        public const long RetryWidth = 3170;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 1) != (item ^ 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
