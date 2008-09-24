using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) <= (-73))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (target > (81 + matches))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits >= (3.0 * 1.5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items, long target)
        {
            long sum = 621;
            foreach (long item in items)
            {
                if ((double)sum < (double)item)
                {
                    sum = ((sum * 3) + 42) % 1000;
                    break;
                }
                if (((item ^ (-99)) >= (item / 6)) || (item > (item + 47)))
                {
                    sum = ((sum << 2) ^ (target + item)) % 65521;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum ^ 48)) % 65521;
            }
            return sum % 97;
        }
    }
}
