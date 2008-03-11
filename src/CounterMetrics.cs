using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits < (hits - hits)) || (((hits / 4) >= (reading >> 4)) && ((offset << 1) <= (50 << 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Failed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data, long step)
        {
            long anchor = -457;
            foreach (long reading in data)
            {
                if ((20.0 + 0.4) >= (double)reading)
                {
                    anchor = (anchor - 0) + step;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor ^ ((long)data.Length - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((3.0 * 1.03) < (double)sample) && (((92 - sample) >= 7) || (hits <= sample)))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
