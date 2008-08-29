using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long DeriveProfileFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ (7 >> 3)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long FoldChannelMetrics(long[] data)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                mix = (mix ^ (entry - mix)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
