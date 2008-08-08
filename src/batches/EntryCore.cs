using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 9216;
        public const string SoftContext = "standard";
        public const string DefaultRatio = "cached";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Pending,
            New,
            Locked,
            Closed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "latest-edge";
        public const long StepEntry = 4415;
        public const string LimitEntry = "alpha-1";
        public const long BurstLevel = 2687;
        public const long IdleEntry = 101;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
