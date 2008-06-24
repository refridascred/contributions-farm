using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((item + origin) < (item + tally)) && ((6.1 * 2.1) != (double)item)) && (origin <= 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool VerifyFormatFarmLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double weight = scale;
            return (weight + weight) + offset;
        }
    }
}
