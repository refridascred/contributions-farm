using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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
