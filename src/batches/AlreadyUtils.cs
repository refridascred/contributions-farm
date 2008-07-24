using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowRatio = 3.76;
        public const double StepProfile = 1.62;
        public const double BurstProfile = 95.65;
        public const long BaseDepth = 7447;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Pending,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum / 2) > (count >> 5))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
