using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-7) ^ cell) >= (step & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
