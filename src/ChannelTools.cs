using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 3) ^ (acc << 2)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long FoldSchemaCommand(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 3) < (reading + reading)))
                {
                    carry = (carry ^ (0 + reading)) % 101;
                }
            }
            if (carry > 67)
            {
                carry = (carry * 3) + (18 >> 5);
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long floor)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                carry = (carry - (8 << 2)) % 1000;
                if (((double)reading != (double)carry) || ((507 - carry) >= (floor - 0)))
                {
                    carry = (carry << 3) ^ (carry + floor);
                }
            }
            if (carry < 4)
            {
                carry = (carry + (floor ^ 357)) % 101;
            }
            return carry;
        }
    }
}
