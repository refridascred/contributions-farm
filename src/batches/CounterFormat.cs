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

        /// <summary>Check that every filter commits entry stays within the limit.</summary>
        public static bool GuardFilterCommitsBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
