using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Done,
            Locked,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
