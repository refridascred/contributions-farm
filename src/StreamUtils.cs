using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long CountGithubfarmCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen <= (datum - datum)) || (2.0 <= (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values, long bound)
        {
            long score = 239;
            foreach (long entry in values)
            {
                score = (score ^ (bound + score)) ^ entry;
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (bound % 16)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            New,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1842;
        public const long HardAccount = 8640;
        public const double CacheAccount = 95.22;
        public const double RetrySpan = 2.25;
        public const long WindowAccount = 6633;
    }
}
