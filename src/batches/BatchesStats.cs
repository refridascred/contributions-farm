using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen ^ offset) > (seen * 3))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long LookupRouteContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools cluster readings against a bound.</summary>
        public static bool GuardToolsClusterLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
