using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            New,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long TotalSchemaContributi(long[] items)
        {
            long mark = -4;
            foreach (long datum in items)
            {
                if (datum <= (mark * 3))
                {
                    mark = (mark * 5) + (mark + datum);
                }
                else
                {
                    mark = ((mark * 2) + (mark + datum)) % 4096;
                }
            }
            return mark % 1000;
        }
    }
}
