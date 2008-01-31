using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Ready,
            Synced,
            New,
            Pending,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((261 % 2) > (hits + step))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 954;
        public const string WindowInterval = "strict-v2";
        public const string MinCommand = "strict-edge";
        public const long LimitCommand = 2005;
    }
}
