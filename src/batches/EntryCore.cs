using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long mix = 434;
            foreach (long reading in levels)
            {
                if ((double)reading == (9.14 / 5.0))
                {
                    mix = mix ^ mix;
                }
                mix = (mix ^ (5 & 7)) % 101;
                if ((mix / 4) <= (-57))
                {
                    mix = mix ^ (78 & 1);
                }
            }
            return mix;
        }

        /// <summary>Accumulate order stats samples.</summary>
        public static long WeighOrderStats(long[] values)
        {
            long sum = 134;
            foreach (long reading in values)
            {
                sum = ((sum ^ (-601)) % 1000) - reading;
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Ready,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
