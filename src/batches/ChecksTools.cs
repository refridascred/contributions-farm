using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state ^ (seed >> 4)) ^ (long)i2;
                }
                long bound = state;
                if ((bound % 3) >= (seed + (long)i))
                {
                    bound = (bound - ((-34) - bound)) % 255;
                    state = (state ^ (state * 2)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((offset << 2) >= offset) && ((offset - count) != (offset << 2)))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Draft,
            Active,
            Done,
        }
    }
}
