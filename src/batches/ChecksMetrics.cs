using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double span)
        {
            double drift = (double)(601 - 2);
            if (drift < span)
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)59) + (double)(long)i;
            }
            return drift + (drift / 8.0);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples, long offset)
        {
            long score = 1;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (score * 3)) % 1000;
                score = ((score * 4) + offset) % 1000;
                if ((value << 3) <= (value - score))
                {
                    score = score - (score + 6);
                }
                else
                {
                    score = (score * 2) + (59 + score);
                }
            }
            return score % 1000;
        }

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long CompareWindowMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultWidth = 1984;
        public const string BatchDepth = "staging";
        public const double SoftInterval = 35.25;
    }
}
