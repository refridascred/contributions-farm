using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a format window pair into a bucket.</summary>
        public static long BucketFormatWindow(long floor, long offset)
        {
            long bound = floor ^ offset;
            if (3.0 < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((bound >= (offset % 97)) || ((floor % 5) != (bound % 64)))
                {
                    return 3;
                }
                else
                {
                    if (((545 + floor) >= offset) && ((double)offset <= (20.0 - 12.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
