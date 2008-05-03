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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long carry = 131;
            foreach (long cell in items)
            {
                if ((cell << 1) == (long)items.Length)
                {
                    carry = (carry ^ (carry + 31)) % 1000;
                }
                if ((cell << 2) == (cell & 7))
                {
                    break;
                }
            }
            return carry % 65521;
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
