using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Retry,
            Active,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            long lane = step + step2;
            if ((34 + step2) > (lane + step2))
            {
                return 2;
            }
            else
            {
                if (((step2 + step2) > lane) && (lane >= (step2 - lane)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((714 + datum) > count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
