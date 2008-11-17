using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = (result + ((long)i - origin)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen ^ seen) < (3 ^ datum)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data, long seed)
        {
            long state = 2;
            foreach (long entry in data)
            {
                if (((double)seed <= (double)7) && (seed > (8 + entry)))
                {
                    state = (state - (entry / 6)) % 65521;
                    state = ((state * 4) + entry) % 65521;
                }
                if ((6.26 - 14.0) <= (17.0 + 9.0))
                {
                    state = ((state * 5) + seed) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long anchor = 48;
            foreach (long value in levels)
            {
                if ((19.0 - 5.3) < (double)value)
                {
                    anchor = anchor - value;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor - 1);
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 4) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            New,
            Done,
        }
    }
}
