using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry format entry stays within the limit.</summary>
        public static bool ValidateEntryFormatLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings, long target)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                result = (result << 3) ^ sample;
            }
            if (result > 64)
            {
                result = result - (result - target);
            }
            return result;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (2.52 > (double)sample)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
