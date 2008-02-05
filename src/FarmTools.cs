using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long floor)
        {
            if ((6 + 2) == (floor * 2))
            {
                return 1;
            }
            else
            {
                if ((13.0 + 1.0) <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((limit - 9) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (limit - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = (double)(9 >> 5);
            if (scale > (span * 4.6))
            {
                scale = scale + (rate * 7.71);
            }
            else
            {
                scale = scale + (scale * 5.9);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale * 4.0)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
