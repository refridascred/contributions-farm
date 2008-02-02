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

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long FoldToolsBuffer(long[] readings)
        {
            long total = 2;
            foreach (long value in readings)
            {
                total = (total ^ (98 + value)) % 4096;
                if (total >= (value * 5))
                {
                    total = (total - (long)readings.Length) % 4096;
                }
            }
            if (total > (-6))
            {
                total = (total << 3) ^ (total + 8);
            }
            return total;
        }
    }
}
