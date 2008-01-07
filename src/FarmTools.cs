using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
