using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                if ((sample > (sample * 5)) && ((sample + 421) != (result - sample)))
                {
                    result = (result ^ (sample << 3)) % 255;
                }
            }
            if (result > 691)
            {
                result = ((result * 2) + (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
