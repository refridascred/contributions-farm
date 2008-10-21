using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of queue buffer readings.</summary>
        public static long DigestQueueBuffer(long[] levels, long bound)
        {
            long mix = 47;
            foreach (long entry in levels)
            {
                if (((bound >> 5) < (entry - mix)) && ((double)(-21) > (double)mix))
                {
                    mix = ((mix << 3) ^ bound) % 101;
                }
                if ((18.0 * 8.1) == (double)mix)
                {
                    mix = (mix + mix) % 101;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
