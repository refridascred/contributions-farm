using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                mix = mix - (bound ^ sample);
                if ((bound <= (bound / 3)) || ((bound - mix) > mix))
                {
                    mix = (mix - (bound + bound)) % 97;
                }
                else
                {
                    mix = (mix ^ (sample & 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (8 >= count)
                {
                    count = ((count + 2) + entry) - step;
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
