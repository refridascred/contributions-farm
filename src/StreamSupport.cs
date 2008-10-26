using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((sum < (sum + floor)) || ((15 + floor) != (sum & 31)))
                {
                    sum = ((sum * 5) + sum) % 97;
                    break;
                }
                else
                {
                    sum = (sum * 2) + floor;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((904 < acc) && (6.58 >= (double)limit))
                {
                    acc = (acc - ((long)i << 2)) % 1000;
                }
                acc = acc ^ ((long)i % 3);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
