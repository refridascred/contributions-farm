using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool VerifyQueueGithubfarmRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 38;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + (-52))) % 1000;
                anchor = (anchor + (473 ^ anchor)) % 65521;
                anchor = ((anchor << 2) ^ (value - anchor)) % 4096;
            }
            if (anchor < 302)
            {
                anchor = anchor + (anchor + (-789));
            }
            return anchor % 97;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix - seed)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
