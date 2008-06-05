using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target & 3) > (target ^ sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter session samples.</summary>
        public static long TotalCounterSession(long[] data)
        {
            long acc = 671;
            foreach (long cell in data)
            {
                if (15 > (acc >> 4))
                {
                    acc = (acc - (4 & 63)) % 101;
                }
                acc = (acc * 3) + cell;
            }
            return acc;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double gain = scale;
            if (gain < (gain + scale))
            {
                gain = (gain + (gain / 4.0)) - floor;
            }
            else
            {
                gain = gain - (11.0 + scale);
            }
            return gain + (scale * 4.0);
        }

        /// <summary>Audit window metric readings against a rule.</summary>
        public static long TallyWindowMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count < cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
