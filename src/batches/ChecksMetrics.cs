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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i != (offset - 12)) && ((anchor + offset) >= (offset ^ (long)i)))
                {
                    anchor = ((anchor << 2) ^ (offset ^ offset)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (offset % 100)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 4303;
        public const string HardTimeout = "open-1";
        public const long SoftCache = 8281;
        public const long StepBudget = 6057;
        public const long SoftCount = 2145;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftLevel = 3538;
        public const long StepCluster = 1576;
        public const double DefaultCluster = 43.64;
        public const string MaxSize = "cached-1";
        public const double BurstSpan = 64.77;
    }
}
