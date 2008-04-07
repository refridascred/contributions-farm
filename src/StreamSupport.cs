using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long target)
        {
            long mix = 73;
            foreach (long sample in samples)
            {
                if (((target / 6) <= sample) || (mix < (sample + mix)))
                {
                    mix = (mix * 5) + (sample / 2);
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Locate a channel account reading by value.</summary>
        public static long FindChannelAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel cluster readings.</summary>
        public static long TotalChannelCluster(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc >= (acc / 5))
                {
                    acc = ((acc * 4) + (423 & 31)) + sample;
                }
            }
            return acc;
        }
    }
}
