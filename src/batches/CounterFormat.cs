using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Locate a window notes reading by value.</summary>
        public static long SeekWindowNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long step)
        {
            if ((step << 1) <= (step & 1))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) != (8 + floor)) || ((step % 3) <= (floor << 1)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
