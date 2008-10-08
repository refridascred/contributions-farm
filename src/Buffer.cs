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

        /// <summary>Derive the next metrics entry value from a seed.</summary>
        public static long RollMetricsEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 3) + score;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
