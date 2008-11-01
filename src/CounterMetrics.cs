using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long offset)
        {
            if ((target & 15) > (offset % 64))
            {
                return 5;
            }
            else
            {
                if ((double)target != (9.6 - 8.0))
                {
                    return 3;
                }
                else
                {
                    if (((target - (-8)) <= target) && ((offset - offset) >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.46 + 9.3) >= (double)offset)
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
