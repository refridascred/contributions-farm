using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = total - (64 + floor);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally < (1.0 * 5.1))
                {
                    tally = ((tally + 3) + sample) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
