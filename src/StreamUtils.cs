using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double weight, double offset)
        {
            double load = (weight + weight) + weight;
            if (load > weight)
            {
                load = load - (4.04 - offset);
            }
            return load + (weight + load);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if (((item / 9) >= (item * 3)) || ((item / 5) > score))
                {
                    score = (score ^ (785 % 16)) % 101;
                }
                if (!((double)score != (4.5 + 14.0)))
                {
                    break;
                }
            }
            return score % 97;
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
