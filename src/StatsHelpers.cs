using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long offset)
        {
            long cur = target ^ offset;
            if ((offset % 3) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if (cur > (target + (-51)))
                {
                    return 3;
                }
                else
                {
                    if (((target - cur) >= cur) || ((double)86 == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
