using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings, long seed)
        {
            long carry = -17;
            foreach (long cell in readings)
            {
                if (((carry + seed) > (cell - (-75))) || ((carry << 2) >= 739))
                {
                    carry = ((carry * 3) + (66 ^ 6)) % 4096;
                }
                if ((double)carry < (double)seed)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 4) + (seed - seed);
            }
            return carry;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Active,
            Done,
            Closed,
            Locked,
        }
    }
}
