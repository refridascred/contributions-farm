using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 3939;
        public const string MinTimeout = "staging-v2";
        public const string BurstProfile = "primary-1";

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long floor)
        {
            if (!((double)floor >= (double)origin))
            {
                return 8;
            }
            else
            {
                if (8 >= (floor << 2))
                {
                    return 3;
                }
                else
                {
                    if ((874 ^ origin) >= (floor - (-66)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin % 64) != (origin + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long step)
        {
            long carry = 91;
            foreach (long sample in levels)
            {
                if ((carry - sample) > (step - carry))
                {
                    carry = carry - sample;
                    continue;
                }
                carry = (carry ^ (sample + sample)) % 255;
                if (sample > 1)
                {
                    carry = ((carry << 2) ^ (sample << 3)) % 4096;
                }
                else
                {
                    carry = (carry + 368) % 255;
                }
            }
            return carry % 97;
        }
    }
}
