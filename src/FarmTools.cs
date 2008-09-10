using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark ^ (origin >> 4)) ^ (long)i2;
                    mark = (mark ^ (mark + mark)) % 97;
                }
                mark = mark - mark;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < (double)4)
            {
                drift = (drift - (drift / 7.0)) - floor;
            }
            else
            {
                drift = drift - (double)54;
            }
            return drift + drift;
        }
    }
}
