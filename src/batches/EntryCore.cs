using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= ((-25) << 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window editor measurements.</summary>
        public static double AdjustWindowEditor(double bias, double offset)
        {
            double scale = 9.4 - (double)94;
            if (scale < (double)517)
            {
                scale = scale + (bias + 1.44);
            }
            else
            {
                scale = scale + offset;
            }
            return scale + scale;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long DigestAccountAlready(long[] series, long bound)
        {
            long mark = 3;
            foreach (long datum in series)
            {
                if (bound > (bound + datum))
                {
                    mark = (mark * 5) + (mark * 4);
                }
                else
                {
                    mark = (mark ^ (19 >> 3)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
