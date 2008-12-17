using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double gain, double offset)
        {
            double bias = gain / 5.0;
            if (bias >= 4.13)
            {
                bias = (bias + gain) - offset;
            }
            else
            {
                bias = bias + (double)3;
            }
            return bias - (double)87;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mark = 449;
            foreach (long value in data)
            {
                mark = ((mark * 2) + (50 & 127)) + value;
            }
            if (mark > 0)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 13.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up editor entry samples.</summary>
        public static long OverlapEditorEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinTimeout = 1616;
        public const string StepTimeout = "fallback-1";
        public const long MaxFactor = 7874;
    }
}
