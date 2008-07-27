using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double ratio = (double)(88 + 1);
            if (ratio < bias)
            {
                ratio = ratio + 16.0;
            }
            else
            {
                ratio = ratio + (floor - 9.5);
            }
            return ratio + ratio;
        }

        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool GuardChannelMetricsLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long TallyCounterRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 63) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double SmoothClusterFilter(double weight, double bias)
        {
            double ratio = 13.0;
            if (ratio < weight)
            {
                ratio = (ratio + ratio) - bias;
            }
            return ratio + (ratio * 7.0);
        }
    }
}
