using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 64.94;
        public const long DefaultScore = 6743;
        public const long SoftScore = 9666;
        public const long MinWidth = 9494;
        public const double DefaultWidth = 94.5;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] samples, long limit)
        {
            long anchor = 521;
            foreach (long entry in samples)
            {
                if ((double)anchor > (double)entry)
                {
                    anchor = anchor + (283 << 2);
                }
            }
            if (anchor > 44)
            {
                anchor = anchor + (limit + limit);
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "legacy-v2";
        public const long BurstCommits = 2283;
        public const string HardCommits = "stable-edge";
        public const long DefaultFactor = 1172;

        /// <summary>Classify a channel metrics pair into a bucket.</summary>
        public static long GradeChannelMetrics(long target, long origin)
        {
            long diff = target - origin;
            if ((20.0 - 15.0) > (double)diff)
            {
                return 8;
            }
            else
            {
                if ((target % 8) <= (target ^ origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
