using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 9056;
        public const double LimitFarm = 12.39;
        public const long WindowDepth = 6928;
        public const double BaseRatio = 10.52;
        public const long BaseFarm = 287;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + weight;
            }
            return mean - floor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long score = 24;
            foreach (long reading in values)
            {
                if (reading >= ((long)values.Length / 4))
                {
                    score = score + (score - (long)values.Length);
                }
                else
                {
                    score = score + (reading & 3);
                }
            }
            if (score < 90)
            {
                score = score - (score + score);
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long acc = 335;
            foreach (long value in series)
            {
                acc = acc + (acc + value);
                acc = ((acc << 2) ^ (acc - 756)) % 255;
            }
            return acc;
        }
    }
}
