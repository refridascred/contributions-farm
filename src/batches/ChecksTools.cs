using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Failed,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long origin)
        {
            long mark = 899;
            foreach (long cell in values)
            {
                if ((double)origin < 2.0)
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
