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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
