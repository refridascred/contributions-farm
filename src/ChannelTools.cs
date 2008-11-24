using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(5.0 <= (double)limit))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
