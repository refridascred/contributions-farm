using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Match up metrics editor samples.</summary>
        public static long MatchMetricsEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Done,
            Locked,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] samples, long seed)
        {
            long anchor = 66;
            foreach (long item in samples)
            {
                anchor = ((anchor ^ anchor) ^ item) - seed;
            }
            return anchor % 97;
        }
    }
}
