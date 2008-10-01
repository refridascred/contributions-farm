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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((origin + 11) != (reading & 7)) || ((tally - (long)items.Length) <= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
