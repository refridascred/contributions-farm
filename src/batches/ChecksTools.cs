using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Active,
            Dropped,
        }

        /// <summary>Classify a route order pair into a bucket.</summary>
        public static long RankRouteOrder(long offset, long seed)
        {
            if ((double)seed != (17.0 * 18.0))
            {
                return 2;
            }
            else
            {
                if (((56 + offset) < (offset - 6)) && ((-5) > (seed % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((3.65 / 3.0) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double gain = 4.3;
            if (gain <= (offset * 3.0))
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + offset) - (double)(long)i;
            }
            return gain + (double)122;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
