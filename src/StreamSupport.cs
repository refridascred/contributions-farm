using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio > weight)
            {
                ratio = (ratio + (double)1) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 4.4) + (double)(long)i;
            }
            return ratio - (weight * 0.61);
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                if ((0.42 / 8.0) >= (double)reading)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            if (mix > (-10))
            {
                mix = mix + ((-403) % 60);
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
