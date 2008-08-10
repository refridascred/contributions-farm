using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Idle,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((966 + entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items)
        {
            long acc = 23;
            foreach (long reading in items)
            {
                acc = (acc ^ reading) % 1000;
            }
            return acc;
        }
    }
}
