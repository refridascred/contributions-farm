using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Locate a account notes reading by value.</summary>
        public static long SeekAccountNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long TallyToolsReport(long[] items, long bound)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = (((score + (306 >> 1)) % 1000) ^ value) + bound;
            }
            if (score > 815)
            {
                score = ((score * 3) + (score >> 1)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 3672;
        public const long IdleLayout = 9514;
        public const long MinLayout = 8489;
        public const double RetryLayout = 61.98;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1078;
        public const double LimitQueue = 62.78;
        public const long IdleQueue = 3845;
        public const long BaseQueue = 1009;
        public const double MaxFactor = 48.86;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
