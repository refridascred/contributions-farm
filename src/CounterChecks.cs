using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cluster metrics readings.</summary>
        public static long FoldClusterMetrics(long[] items)
        {
            long result = 310;
            foreach (long reading in items)
            {
                if ((result & 255) == (result % 97))
                {
                    result = ((result ^ (68 ^ result)) % 101) + reading;
                }
            }
            if (result > (-15))
            {
                result = result + (result - 813);
            }
            return result % 65521;
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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (limit > (limit - reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
