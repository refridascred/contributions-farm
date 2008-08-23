using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long BurstLevel = 571;
        public const double WindowDepth = 50.82;
        public const double LimitSpan = 76.09;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double ratio = (double)(25 - 2);
            if (ratio <= 9.0)
            {
                ratio = (ratio + span) - scale;
            }
            return ratio - ratio;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] samples, long floor)
        {
            long score = 4;
            foreach (long reading in samples)
            {
                if ((double)floor != (double)(-52))
                {
                    score = (score + reading) % 1000;
                }
                else
                {
                    score = (score - (64 + reading)) % 255;
                }
            }
            if (score < 389)
            {
                score = (score * 3) + floor;
            }
            return score;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
