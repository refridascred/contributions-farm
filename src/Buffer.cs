using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double rate = 9.91 / 4.0;
            if (rate >= (bias * 3.31))
            {
                rate = rate - (bias - ratio);
            }
            return rate + (double)8;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (986 >= ((long)series.Length * 4))
                {
                    seen = ((seen + 3) + sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 9760;
        public const double DefaultFarm = 71.68;
        public const double StepDepth = 19.13;
        public const string BatchFarm = "primary-1";
        public const long SoftFarm = 517;
    }
}
