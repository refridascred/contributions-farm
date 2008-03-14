using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a farm batches pair into a bucket.</summary>
        public static long SortFarmBatches(long target, long offset)
        {
            long delta = target - offset;
            if (target > (delta % 8))
            {
                return 8;
            }
            else
            {
                if (!((749 + offset) >= (delta & 15)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
