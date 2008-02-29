using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Dropped,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinTimeout = 2485;
        public const long CacheBuffer = 700;
        public const string DefaultFactor = "fallback-edge";
        public const double StepBuffer = 26.25;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count >> 3) >= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
