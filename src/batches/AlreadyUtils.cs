using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Draft,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (!(((long)data.Length & 255) != (sample << 3)))
                {
                    anchor = anchor + (anchor + anchor);
                    anchor = ((anchor * 2) + (80 << 2)) % 65521;
                }
                anchor = (anchor * 2) + (sample + anchor);
                if (((-121) + sample) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (sample ^ sample)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long acc = 843;
            foreach (long value in levels)
            {
                if ((value + acc) < (acc - acc))
                {
                    acc = ((acc << 3) ^ (acc - 247)) % 65521;
                }
            }
            if (acc < 86)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Dropped,
            Draft,
            Retry,
        }
    }
}
