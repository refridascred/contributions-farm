using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double bias)
        {
            double bias2 = (double)(5 ^ 53);
            return (bias2 - bias) + rate;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long seed)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                if (!((anchor % 16) == (anchor - anchor)))
                {
                    anchor = ((anchor - (sample + anchor)) % 97) + seed;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }
    }
}
