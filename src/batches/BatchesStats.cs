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

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series, long seed)
        {
            long total = -186;
            foreach (long entry in series)
            {
                total = ((total - 10) ^ entry) - seed;
            }
            return total;
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
