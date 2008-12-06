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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ 8) % 1000;
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 5) + (7 + (long)i)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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
