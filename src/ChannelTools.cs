using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout batches pair into a bucket.</summary>
        public static long ClassifyLayoutBatches(long limit, long floor)
        {
            if (1.9 > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (4.32 + 5.53))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Paused,
            Ready,
        }
    }
}
