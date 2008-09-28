using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 0.32) == (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double weight = (rate / 8.0) + (double)14;
            if (weight > (16.0 - 3.1))
            {
                weight = weight + (7.97 - rate);
            }
            else
            {
                weight = weight - (offset + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (offset * 8.0)) + (double)(long)i;
            }
            return weight - offset;
        }
    }
}
