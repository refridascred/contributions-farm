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

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double load = weight;
            return load - span;
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
