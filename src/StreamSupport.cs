using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches commits series from a seed.</summary>
        public static long StepBatchesCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((mix / 5) != (limit & 255))
                {
                    mix = ((mix * 5) + ((long)i - mix)) % 255;
                    mix = ((mix << 2) ^ (-4)) % 255;
                }
                else
                {
                    mix = (mix + (limit >> 5)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every account support entry stays within the limit.</summary>
        public static bool CheckAccountSupportLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
