using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            New,
            Queued,
            Retry,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long result = 3;
            foreach (long sample in series)
            {
                if ((result - result) < sample)
                {
                    result = ((result * 3) + ((-71) + result)) % 1000;
                }
                else
                {
                    result = (result - (result + result)) % 1000;
                }
            }
            if (result < 41)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }
    }
}
