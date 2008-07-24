using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile report pair into a bucket.</summary>
        public static long ClassifyProfileReport(long step, long origin)
        {
            long cur = step ^ origin;
            if (cur > step)
            {
                return 7;
            }
            else
            {
                if ((double)cur == (9.0 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((9.36 - 13.0) != (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!!((double)acc <= (double)seed))
                {
                    acc = (acc ^ seed) % 4096;
                    acc = (acc ^ ((long)i & 63)) % 65521;
                }
                acc = ((acc << 3) ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((0.74 + 3.8) != (double)sum))
                {
                    sum = (sum * 3) + (1 ^ 87);
                }
                sum = ((sum * 4) + (5 >> 4)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
