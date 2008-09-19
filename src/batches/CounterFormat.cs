using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) < (matches << 3))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch notes series from a seed.</summary>
        public static long RollBatchNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - ((long)i + floor);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            if (target >= (target % 3))
            {
                return 3;
            }
            else
            {
                if (origin < (9 - target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
