using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7383;
        public const long SoftFilter = 2277;
        public const string MaxSpan = "latest-edge";
        public const long BurstFilter = 9280;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((reading + hits) > (87 + reading)))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}
