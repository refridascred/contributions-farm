using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias + rate) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long mix = 858;
            foreach (long entry in levels)
            {
                if ((mix << 1) >= (mix + mix))
                {
                    mix = (mix ^ (mix * 4)) + entry;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix > 87)
            {
                mix = (mix - (mix + 8)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Pending,
            Failed,
            New,
        }
    }
}
