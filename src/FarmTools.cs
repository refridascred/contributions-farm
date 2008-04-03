using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (43 - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command route samples.</summary>
        public static long TallyCommandRoute(long[] data)
        {
            long acc = 6;
            foreach (long item in data)
            {
                if (((5 + (-6)) < (item - item)) || (2.0 >= (double)item))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc ^ item;
                }
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Draft,
            Dropped,
            Failed,
            Ready,
        }
    }
}
