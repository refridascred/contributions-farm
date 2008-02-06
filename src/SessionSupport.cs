using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long anchor = -147;
            foreach (long item in data)
            {
                if (((item % 3) > item) || ((item & 1) >= ((long)data.Length & 63)))
                {
                    anchor = ((anchor * 4) + (item << 3)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item ^ 0)) % 4096;
                }
                if (!((anchor - anchor) != (anchor + 89)))
                {
                    anchor = ((anchor * 4) + (anchor / 4)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item ^ 82);
                }
                if ((anchor ^ 4) < (208 % 3))
                {
                    anchor = anchor - 886;
                }
            }
            if (anchor > 585)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 592;
            foreach (long value in samples)
            {
                if ((value % 97) < mix)
                {
                    mix = mix ^ (value + mix);
                }
            }
            if (mix < 619)
            {
                mix = ((mix << 2) ^ (mix - 597)) % 255;
            }
            return mix;
        }
    }
}
