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

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
