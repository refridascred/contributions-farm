using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long step)
        {
            long mark = 690;
            foreach (long item in series)
            {
                if ((step + step) < (item / 5))
                {
                    mark = (mark ^ item) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ item) % 255;
                }
            }
            if (mark > (-375))
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long sum = -5;
            foreach (long sample in values)
            {
                sum = ((sum - (sum >> 5)) % 97) - sample;
            }
            if (sum > (-52))
            {
                sum = (sum ^ (origin % 12)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry == (3.9 - 18.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Locked,
            Ready,
            Draft,
            Retry,
        }
    }
}
