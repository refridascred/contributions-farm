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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
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
