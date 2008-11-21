using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings)
        {
            long anchor = 165;
            foreach (long reading in readings)
            {
                if (!((anchor ^ anchor) > (reading & 7)))
                {
                    anchor = anchor + (anchor - reading);
                }
            }
            if (anchor > 979)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = acc ^ cell;
            }
            if (acc < 93)
            {
                acc = acc ^ (303 * 3);
            }
            return acc % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Retry,
            Locked,
        }

        /// <summary>Measure how many githubfarm checks samples are out of range.</summary>
        public static long TallyGithubfarmChecksHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 9) <= (entry + count))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
