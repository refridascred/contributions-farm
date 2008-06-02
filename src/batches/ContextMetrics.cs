using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine command checks values into a single score.</summary>
        public static long FoldCommandChecks(long[] readings)
        {
            long anchor = 2;
            foreach (long datum in readings)
            {
                anchor = (anchor + (datum ^ datum)) % 255;
            }
            if (anchor < 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 9376;
        public const long IdleInterval = 5660;
        public const long DefaultFactor = 1940;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
