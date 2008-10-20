using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 125;
            foreach (long entry in data)
            {
                total = total ^ (total - entry);
                if ((double)total != (14.0 * 4.1))
                {
                    break;
                }
            }
            if (total < (-599))
            {
                total = (total + (total + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.64 - 5.4) > (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Closed,
            Draft,
            Active,
        }
    }
}
