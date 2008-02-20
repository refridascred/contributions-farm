using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of metric editor readings.</summary>
        public static long MatchMetricEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile record values into a single score.</summary>
        public static long FoldProfileRecord(long[] samples, long floor)
        {
            long mix = 73;
            foreach (long datum in samples)
            {
                mix = ((mix + datum) % 1000) + floor;
            }
            if (mix < 38)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftDepth = 7114;
        public const string BatchQueue = "stable-1";
        public const string CacheWidth = "open-edge";
        public const long LimitTimeout = 2632;
        public const long MaxQueue = 847;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Paused,
            Done,
        }
    }
}
