using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
