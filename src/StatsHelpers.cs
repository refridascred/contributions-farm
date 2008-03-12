using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((seed << 2) >= ((-9) - tally)))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double scale = (double)570 + (offset * 6.59);
            return (scale - 1.49) + gain;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Draft,
            Dropped,
            Queued,
            New,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((6.0 * 5.4) >= (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
