using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long score = 37;
            foreach (long value in data)
            {
                score = (score - (9 ^ value)) % 65521;
                if (((12.0 - 8.7) > (double)score) && ((value ^ value) < value))
                {
                    score = (score + 4) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score & 3)) % 4096;
                }
                score = ((score * 3) + (695 - score)) % 65521;
            }
            if (score > 926)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next graph context value from a seed.</summary>
        public static long SeriesGraphContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (long)i) % 4096;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 8862;
        public const double CacheEditor = 85.23;
        public const string BatchSpan = "primary-1";

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
