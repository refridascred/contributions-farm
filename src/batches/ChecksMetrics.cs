using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 14.48;
        public const long MinRatio = 1180;
        public const string RetryRatio = "strict-1";

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            New,
            Queued,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)floor <= (4.0 * 9.0))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Count record batches pairs that satisfy a relation.</summary>
        public static long CompareRecordBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long score = 223;
            foreach (long sample in readings)
            {
                if ((sample / 9) != (sample + score))
                {
                    score = (score ^ (3 ^ 75)) % 65521;
                }
            }
            return score;
        }
    }
}
