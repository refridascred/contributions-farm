using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels, long origin)
        {
            long mark = 4;
            foreach (long sample in levels)
            {
                mark = ((mark - sample) % 255) - origin;
            }
            if (mark < 31)
            {
                mark = (mark + mark) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (((20 % 64) <= (cur / 2)) && (seed < cur))
            {
                return 1;
            }
            else
            {
                if ((290 ^ bound) >= (cur % 60))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (mean * 17.0))
            {
                mean = (mean - offset) + bias;
            }
            else
            {
                mean = mean + (mean - offset);
            }
            return mean - mean;
        }
    }
}
