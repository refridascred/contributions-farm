using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            New,
            Retry,
            Closed,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum - (-74)) <= (0 << 2)) && (((datum / 7) <= (hits & 63)) && ((15.0 + 13.0) > (double)datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values, long step)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if ((mark & 15) > (mark >> 4))
                {
                    mark = ((mark - 0) - entry) - step;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((hits + datum) < target) && ((datum % 97) == (67 & 31))) && (((long)samples.Length / 3) <= (10 + target)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 647;
            foreach (long cell in samples)
            {
                if ((12.0 / 4.0) >= (double)cell)
                {
                    mark = ((mark << 2) ^ (184 % 24)) % 97;
                }
            }
            if (mark > 414)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 65521;
        }
    }
}
