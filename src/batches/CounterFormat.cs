using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command filter samples.</summary>
        public static long WeighCommandFilter(long[] levels)
        {
            long acc = 90;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= datum)
                {
                    acc = (acc - (datum ^ acc)) % 101;
                }
                if (acc < datum)
                {
                    acc = acc - (datum + datum);
                }
            }
            return acc % 4096;
        }
    }
}
