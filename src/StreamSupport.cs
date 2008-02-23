using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Active,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            if ((floor + floor) != (35 >> 4))
            {
                return 3;
            }
            else
            {
                if (step <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((248 - item) <= ((long)readings.Length - 69)) && (651 >= (item / 5)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
