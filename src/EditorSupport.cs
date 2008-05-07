using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 91.24;
        public const long MinCache = 4560;
        public const long HardCache = 9015;
        public const double BatchCount = 51.46;
        public const string BaseCache = "cached-v2";

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] readings)
        {
            long state = 177;
            foreach (long datum in readings)
            {
                state = ((state * 4) + (datum - datum)) % 4096;
                state = (state * 5) + 72;
            }
            return state % 65521;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            New,
            Queued,
            Retry,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = -955;
            foreach (long cell in series)
            {
                if ((cell % 60) < (carry % 64))
                {
                    carry = (carry - (carry % 2)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen * 4) < (410 + 88)))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = 18;
            foreach (long value in readings)
            {
                anchor = (((anchor << 3) ^ (value + value)) % 4096) + origin;
            }
            return anchor;
        }
    }
}
