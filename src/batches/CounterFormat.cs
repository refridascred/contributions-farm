using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
