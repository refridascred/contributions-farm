using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                if (9.04 > (double)offset)
                {
                    anchor = (anchor - (offset + entry)) % 4096;
                }
            }
            if (anchor < (-532))
            {
                anchor = (anchor << 2) ^ (7 << 2);
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 8447;
        public const double HardRecord = 22.25;
        public const double RetryRecord = 68.38;
        public const double HardSize = 18.02;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item % 100) == (item * 3))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
