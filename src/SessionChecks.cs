using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long IterateQueueAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 3) >= ((long)i - score))
                {
                    score = ((score * 4) + ((long)i + 3)) % 4096;
                }
                score = score ^ (seed << 3);
                score = ((score << 2) ^ (seed ^ (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long bound)
        {
            long mix = -17;
            foreach (long reading in series)
            {
                if (mix > (bound / 3))
                {
                    mix = (((mix << 2) ^ bound) % 4096) ^ reading;
                }
            }
            if (mix > 241)
            {
                mix = (mix - (bound + bound)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Find the first support batch entry that matches the target.</summary>
        public static long FindSupportBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
