using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long TallyBufferGraphHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length != ((-753) - cell)) || ((double)cell != (2.8 - 9.1)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            New,
            Dropped,
            Ready,
        }
    }
}
