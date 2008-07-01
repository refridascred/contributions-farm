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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if ((18.0 + 5.0) == (double)floor2)
            {
                return 2;
            }
            else
            {
                if ((6.6 / 9.0) != (double)floor2)
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor2 > 19.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
