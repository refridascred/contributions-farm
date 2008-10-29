using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long seed)
        {
            if ((offset - 890) >= offset)
            {
                return 0;
            }
            else
            {
                if ((90 >> 4) == (offset - offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstFactor = 25.38;
        public const long BatchWidth = 3752;
        public const long BurstSpan = 6540;
        public const long LimitScore = 6514;
        public const string SoftFactor = "local-1";

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double drift = 3.67;
            if (drift <= (double)0)
            {
                drift = drift - (gain / 6.0);
            }
            return drift + span;
        }
    }
}
