using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (14.0 + 13.0))
            {
                rate2 = rate2 + (double)16;
            }
            return rate2 + (rate * 16.0);
        }

        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool GuardRecordEntryRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
