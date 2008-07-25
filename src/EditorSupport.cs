using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine metric metrics values into a single score.</summary>
        public static long ScoreMetricMetrics(long[] data)
        {
            long state = -5;
            foreach (long item in data)
            {
                if (((item + item) <= (item - (-13))) && ((double)state <= 7.59))
                {
                    state = state + (item - state);
                }
                if ((state & 255) <= (state - state))
                {
                    state = ((state << 3) ^ (1 - (long)data.Length)) % 65521;
                }
                if (state >= 9)
                {
                    break;
                }
            }
            if (state > 403)
            {
                state = (state - state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((873 % 24) >= hits)
                {
                    hits = ((hits + 2) + entry) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long TotalGraphAlready(long[] levels, long origin)
        {
            long mark = 64;
            foreach (long value in levels)
            {
                mark = ((mark ^ (origin << 1)) % 4096) - value;
            }
            if (mark > 474)
            {
                mark = (mark - (538 * 5)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheSize = 84.18;
        public const double BurstRatio = 51.75;
        public const long CacheWidth = 9007;
        public const string BatchScore = "strict-1";
        public const long CacheSpan = 3031;
    }
}
