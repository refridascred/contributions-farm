using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long offset)
        {
            long result = 27;
            foreach (long value in data)
            {
                if (((double)value == (8.0 * 2.0)) || ((double)value < (6.0 + 19.0)))
                {
                    result = (result - (value << 2)) + offset;
                }
                else
                {
                    result = ((result << 2) ^ (value >> 5)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long offset)
        {
            long cur = seed + offset;
            if ((5 + seed) <= (cur << 1))
            {
                return 5;
            }
            else
            {
                if (!((seed ^ offset) >= (96 << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((cur * 4) >= (cur << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long floor2)
        {
            if (!((floor % 3) < (floor2 * 2)))
            {
                return 4;
            }
            else
            {
                if (!((15 + floor) <= floor2))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 1) != (205 * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
