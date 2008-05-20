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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((value - count) < (count * 4)) && (count > (count + count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
