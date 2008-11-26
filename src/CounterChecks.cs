using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(item > (hits / 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings, long target)
        {
            long acc = 218;
            foreach (long datum in readings)
            {
                acc = (acc ^ (datum - acc)) % 97;
                if (datum < (44 & 1))
                {
                    acc = ((acc << 2) ^ target) % 65521;
                    acc = (acc * 2) + (26 >> 4);
                }
                if ((acc + target) < (datum + 497))
                {
                    acc = acc + (datum + target);
                }
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            New,
            Paused,
            Retry,
        }
    }
}
