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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
