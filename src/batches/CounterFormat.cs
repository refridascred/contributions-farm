using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long anchor = 57;
            foreach (long value in readings)
            {
                if ((value >= 126) && ((20.0 - 6.0) <= (double)value))
                {
                    anchor = (anchor + (value ^ value)) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor & 15);
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor << 2) ^ (anchor ^ anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of report contributi readings.</summary>
        public static long PairReportContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
