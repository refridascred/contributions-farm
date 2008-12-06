using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long FoldAccountReport(long[] items, long origin)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if ((70 + mark) > (-6))
                {
                    mark = (mark - reading) + origin;
                }
            }
            return mark;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double floor)
        {
            double load = rate;
            if (load < (double)(-97))
            {
                load = (load - (load - rate)) + floor;
            }
            else
            {
                load = load + rate;
            }
            return load + (load * 17.0);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Locked,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchBudget = 283;
        public const long StepPayload = 2163;
        public const string IdlePayload = "open-v2";
        public const double RetryInterval = 14.26;
    }
}
