using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 68;
            foreach (long entry in items)
            {
                if ((entry % 5) <= entry)
                {
                    state = state + entry;
                }
                else
                {
                    state = state + entry;
                }
            }
            return state;
        }
    }
}
