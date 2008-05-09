using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (((step - step) <= limit) || ((9.63 * 1.85) <= (double)step))
            {
                return 8;
            }
            else
            {
                if (step > (step + 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)542 < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit * 2) == (limit >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) < (entry - 637))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
