using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Ready,
            New,
            Active,
            Stale,
        }

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long CountGraphFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((35 >> 2) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 20.35;
        public const long BatchWindow = 2025;
        public const double MaxWidth = 22.6;
        public const string CacheWindow = "stable-edge";

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mix = 272;
            foreach (long datum in values)
            {
                if (!((mix % 7) < (mix >> 3)))
                {
                    mix = (mix ^ (limit / 4)) ^ datum;
                }
            }
            return mix;
        }
    }
}
