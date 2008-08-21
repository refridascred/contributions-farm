using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((297 % 100) >= (item + 5)) && ((tally >> 4) >= tally)) && ((tally <= (item ^ tally)) || (item < (640 + item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate queue entry readings against a bound.</summary>
        public static bool ValidateQueueEntryBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 261;
            foreach (long datum in levels)
            {
                result = (result ^ (result ^ datum)) % 101;
            }
            return result;
        }
    }
}
