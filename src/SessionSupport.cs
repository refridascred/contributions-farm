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

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)425 <= (double)step)
                {
                    carry = carry ^ 5;
                }
                if (((-3) & 7) > step)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
