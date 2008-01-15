using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((total + 986) > (value + value)) || (total > (total & 127)))
                {
                    total = (total - (total >> 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the tools profile entries that pass the check.</summary>
        public static long CountToolsProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + reading) == (matches - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (8 + 93)) % 4096;
                carry = carry + (origin >> 5);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
