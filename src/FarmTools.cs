using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((452 + anchor) > (anchor >> 1)))
                {
                    anchor = anchor - (anchor / 6);
                }
                else
                {
                    anchor = anchor + (anchor ^ step);
                    anchor = anchor - (step % 16);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
