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

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double gain = 2.2 - scale;
            return (gain - gain) + floor;
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
