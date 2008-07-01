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

        /// <summary>Derive the next batches queue value from a seed.</summary>
        public static long DeriveBatchesQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                long prev = ((long)i % 10) / 4;
                carry = ((carry << 2) ^ (prev << 3)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
