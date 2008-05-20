using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
