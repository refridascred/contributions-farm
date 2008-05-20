using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample + matches) > sample) || ((matches + sample) > (sample / 2))) && ((matches << 2) > (sample * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer schema readings against a bound.</summary>
        public static bool VerifyBufferSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((datum ^ datum) != (datum - datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((anchor + 188) > (item + anchor))
                {
                    anchor = anchor ^ 8;
                }
                if ((double)item < (6.4 * 0.2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9920;
        public const string BaseCounter = "strict";
        public const double CacheSpan = 81.47;
        public const long SoftSize = 9430;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
