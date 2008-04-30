using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long floor)
        {
            long slot = step + floor;
            if ((slot + slot) < floor)
            {
                return 7;
            }
            else
            {
                if ((791 << 1) >= (slot % 10))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step ^ step) <= 159) && ((72 >> 1) >= (step * 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Ready,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2184;
        public const long RetryDepth = 364;
        public const long DefaultTimeout = 9764;
    }
}
