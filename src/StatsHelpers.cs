using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ ((long)i << 2);
                if ((step / 3) >= result)
                {
                    result = (result + (result * 5)) % 65521;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema already counter forward.</summary>
        public static long RollSchemaAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 101;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Paused,
        }
    }
}
