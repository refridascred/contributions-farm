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

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 4703;
        public const long StepAlready = 4486;
        public const long BurstLevel = 9061;
        public const string CacheRatio = "staging-edge";
    }
}
