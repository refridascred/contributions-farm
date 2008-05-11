using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every window githubfarm entry stays within the limit.</summary>
        public static bool VerifyWindowGithubfarmLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)seed != (7.0 / 5.0)) || ((1.0 + 5.0) <= (double)slot))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate filter record samples.</summary>
        public static long CombineFilterRecord(long[] data)
        {
            long mark = 727;
            foreach (long item in data)
            {
                mark = ((mark * 4) + (item << 2)) % 65521;
            }
            return mark % 97;
        }
    }
}
