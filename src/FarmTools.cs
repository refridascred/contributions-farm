using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
