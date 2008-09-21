using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate githubfarm graph readings against a bound.</summary>
        public static bool ValidateGithubfarmGraphRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long anchor = 10;
            foreach (long cell in samples)
            {
                if (anchor >= (cell >> 3))
                {
                    anchor = (anchor * 2) + (anchor * 2);
                }
                else
                {
                    anchor = (anchor - (cell + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 3) ^ ((-680) * 5)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
