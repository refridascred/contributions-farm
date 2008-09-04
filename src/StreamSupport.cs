using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of filter tools readings.</summary>
        public static long OverlapFilterToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long mix = 121;
            foreach (long sample in readings)
            {
                mix = ((mix - (mix + mix)) % 255) ^ sample;
                mix = (mix + (mix % 12)) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
