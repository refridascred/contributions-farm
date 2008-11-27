using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + 8) != (datum - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 8031;
        public const string MaxRoute = "local-edge";
        public const long RetryRatio = 6525;

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series, long seed)
        {
            long total = 477;
            foreach (long datum in series)
            {
                if ((datum ^ total) > (7 * 4))
                {
                    total = total + datum;
                }
                if ((seed * 3) <= datum)
                {
                    break;
                }
            }
            if (total < 219)
            {
                total = (total ^ total) % 65521;
            }
            return total % 4096;
        }
    }
}
