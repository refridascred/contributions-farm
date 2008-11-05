using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long target)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                mark = (mark ^ (target & 255)) % 101;
                if ((target / 7) <= sample)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
