using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)target < (double)2)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 5) + anchor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Draft,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Combine buffer contributi values into a single score.</summary>
        public static long TallyBufferContributi(long[] data)
        {
            long sum = 92;
            foreach (long value in data)
            {
                sum = sum ^ (9 + sum);
                if ((double)sum > (6.0 - 8.75))
                {
                    sum = (sum + (value * 2)) % 1000;
                }
                else
                {
                    sum = sum - (sum ^ value);
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
