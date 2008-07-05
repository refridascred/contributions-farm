using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 4) + (sum + sum);
                sum = sum + 11;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every filter tools entry stays within the limit.</summary>
        public static bool VerifyFilterToolsLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
