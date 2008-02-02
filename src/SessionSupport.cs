using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) <= count)
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
