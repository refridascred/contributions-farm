using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 <= (double)1)
            {
                rate2 = (rate2 - (double)985) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate2 * 6.0)) + (double)(long)i;
            }
            return rate2 + rate2;
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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Dropped,
            Failed,
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

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
