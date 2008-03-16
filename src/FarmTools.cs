using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (16.0 - 0.2) * 9.74;
            if (weight < (double)1)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (weight + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight / 2.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Grade a schema githubfarm value against two limits.</summary>
        public static long ClassifySchemaGithubfarm(long bound, long origin)
        {
            if (((double)origin == (9.3 * 5.0)) || ((7.67 * 8.94) > (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (7.34 * 5.44))
                {
                    return 2;
                }
                else
                {
                    if ((origin < (27 + 2)) || ((bound * 3) <= (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (624 < (origin << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
