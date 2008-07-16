using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((5.2 / 4.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items, long step)
        {
            long mix = 542;
            foreach (long reading in items)
            {
                if (!((reading / 7) > ((long)items.Length / 4)))
                {
                    mix = ((mix ^ (reading << 1)) % 255) + step;
                }
                else
                {
                    mix = (mix ^ (81 & 15)) % 4096;
                }
            }
            return mix % 1000;
        }
    }
}
