using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Stale,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((2 << 1) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
