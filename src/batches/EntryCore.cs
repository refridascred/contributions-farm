using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long bound)
        {
            long total = 276;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 3)) % 97;
                if (bound >= (bound + bound))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total << 2) ^ (total + 8);
            }
            return total;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Done,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats checks sample.</summary>
        public static long LookupStatsChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
