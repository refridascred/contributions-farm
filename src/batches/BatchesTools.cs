using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 944;
            foreach (long value in readings)
            {
                if ((double)score > (double)value)
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score - (score >> 3)) % 65521;
                score = (score << 2) ^ (3 + floor);
            }
            return score;
        }

        /// <summary>Roll a stats githubfarm counter forward.</summary>
        public static long SeriesStatsGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (target + target)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
