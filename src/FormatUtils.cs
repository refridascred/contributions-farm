using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = mix - ((long)i + seed);
                if ((double)9 >= (double)seed)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] readings)
        {
            long result = 628;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (93 % 60)) % 255) - (long)i;
                }
                if ((result + result) <= result)
                {
                    result = (result ^ (1 ^ cell)) % 1000;
                }
                else
                {
                    result = result + cell;
                }
            }
            return result;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double rate = 10.0;
            return ((rate - 0.06) + weight) + offset;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            New,
            Stale,
            Ready,
        }
    }
}
