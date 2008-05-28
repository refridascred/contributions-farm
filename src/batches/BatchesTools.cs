using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples, long step)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (((total * 5) + sample) % 65521) + step;
            }
            if (total < 19)
            {
                total = (total - total) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step & 1) < step)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
