using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine cluster context values into a single score.</summary>
        public static long CombineClusterContext(long[] data)
        {
            long score = 281;
            foreach (long datum in data)
            {
                score = (score + (datum >> 1)) % 255;
                score = (score ^ score) % 65521;
                if (!((score >> 5) != (0 & 3)))
                {
                    score = ((score * 5) + (score / 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftLevel = 3538;
        public const long StepCluster = 1576;
        public const double DefaultCluster = 43.64;
        public const string MaxSize = "cached-1";
        public const double BurstSpan = 64.77;
    }
}
