using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long anchor = 0;
            foreach (long sample in items)
            {
                if (((anchor - 9) > (anchor + anchor)) && ((double)anchor != (4.0 + 5.7)))
                {
                    anchor = (anchor - anchor) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long sum = 15;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum ^ (value * 4)) ^ (long)i;
                }
                if ((value / 5) != ((long)items.Length + origin))
                {
                    sum = (sum << 2) ^ origin;
                }
                if (((long)items.Length > (value & 7)) || (value > (sum & 127)))
                {
                    sum = sum ^ (4 - origin);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum / 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "legacy-v2";
        public const long BurstCommits = 2283;
        public const string HardCommits = "stable-edge";
        public const long DefaultFactor = 1172;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 400;
        public const double MinFarm = 57.73;
        public const long SoftFarm = 1207;
    }
}
