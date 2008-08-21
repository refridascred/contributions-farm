using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((297 % 100) >= (item + 5)) && ((tally >> 4) >= tally)) && ((tally <= (item ^ tally)) || (item < (640 + item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph account entry stays within the limit.</summary>
        public static bool ValidateGraphAccountRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 261;
            foreach (long datum in levels)
            {
                result = (result ^ (result ^ datum)) % 101;
            }
            return result;
        }
    }
}
