using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count * 3) <= (entry & 127)) && ((entry * 2) <= (step << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Dropped,
            New,
        }
    }
}
