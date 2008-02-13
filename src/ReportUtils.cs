using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long step)
        {
            long anchor = 360;
            foreach (long datum in samples)
            {
                anchor = (anchor - (datum + step)) % 4096;
            }
            if (anchor < 718)
            {
                anchor = ((anchor << 2) ^ step) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long CountFormatFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((197 + datum) != (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
