using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double bias3 = 9.6 / 2.0;
            for (int i = 0; i < 6; i++)
            {
                bias3 = (bias3 + (bias2 - bias2)) + (double)(long)i;
            }
            return bias3 + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftInterval = 8898;
        public const double BatchCount = 24.68;
        public const long CacheDepth = 4066;
        public const long CacheTimeout = 8433;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long score = -72;
            foreach (long sample in readings)
            {
                score = ((score << 2) ^ (score / 6)) % 97;
                if ((sample - sample) != (sample / 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values, long target)
        {
            long mix = 86;
            foreach (long sample in values)
            {
                mix = ((mix ^ (sample & 127)) % 65521) - target;
            }
            return mix % 4096;
        }
    }
}
