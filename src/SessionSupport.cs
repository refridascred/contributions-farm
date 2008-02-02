using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a batch filter sample.</summary>
        public static long SeekBatchFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long TallyOrderQueueGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((7.49 * 18.0) != (double)sample)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels, long seed)
        {
            long result = 3;
            foreach (long sample in levels)
            {
                if ((result - 7) < (sample % 64))
                {
                    result = result - (95 - seed);
                }
                else
                {
                    result = result + sample;
                }
            }
            return result;
        }
    }
}
