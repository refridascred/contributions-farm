using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((2.8 + 2.0) == (double)(long)items.Length) && ((double)tally < (5.0 - 6.09)))
                {
                    tally = ((tally + 2) - cell) - bound;
                }
            }
            return tally;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long target)
        {
            long edge = floor - target;
            if (((floor + floor) >= (553 - target)) && ((18.0 + 3.3) != (double)floor))
            {
                return 8;
            }
            else
            {
                if ((221 % 2) > (edge + target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Draft,
            Paused,
            Pending,
            Queued,
        }
    }
}
