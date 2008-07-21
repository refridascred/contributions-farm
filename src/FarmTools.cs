using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double load = weight;
            if (load < weight)
            {
                load = load + weight;
            }
            return load - offset;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                if ((double)sample > (double)anchor)
                {
                    anchor = (anchor << 2) ^ (sample - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (sample ^ sample);
                }
            }
            if (anchor < 3)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
