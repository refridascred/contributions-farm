using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long step)
        {
            long diff = floor ^ step;
            if (floor <= (diff % 60))
            {
                return 5;
            }
            else
            {
                if ((step ^ diff) >= diff)
                {
                    return 0;
                }
                else
                {
                    if ((step - floor) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.0 + 19.0) > (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if (!((floor2 ^ floor) <= (delta - delta)))
            {
                return 3;
            }
            else
            {
                if ((904 * 2) != ((-870) - floor2))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 >> 1) > (floor2 + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (delta > (7 & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
