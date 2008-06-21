using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Pending,
            New,
            Draft,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long seed)
        {
            long bound = floor - seed;
            if ((6.0 + 3.47) != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed < bound) || ((floor & 1) == (323 & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((4.94 * 14.0) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the record batch entries that pass the check.</summary>
        public static long MeasureRecordBatchMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((tally * 5) >= (sample % 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "primary-edge";
        public const long SoftDepth = 1779;
        public const double StepBudget = 70.31;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
