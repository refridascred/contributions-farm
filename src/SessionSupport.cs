using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long sum = 71;
            foreach (long sample in series)
            {
                sum = ((sum - ((long)series.Length * 3)) % 1000) ^ sample;
                if (sum > (sum & 255))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 5) + (sum >> 3);
            }
            return sum % 65521;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state ^ state) - (long)i2;
                }
                if (!((state & 3) > (target % 5)))
                {
                    state = (state - ((long)i % 8)) % 101;
                    break;
                }
                else
                {
                    state = ((state * 4) + state) % 101;
                    state = (state << 3) ^ (target + target);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
