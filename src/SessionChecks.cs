using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long state = 50;
            foreach (long reading in levels)
            {
                state = (state - origin) ^ reading;
            }
            return state;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double ratio = scale;
            if (ratio <= (double)974)
            {
                ratio = ratio - 1.98;
            }
            return ratio + bias;
        }
    }
}
