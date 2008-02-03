using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 361;
        public const long BaseStats = 3940;
        public const long MaxDepth = 1253;
        public const long RetryStats = 179;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Classify a entry batches pair into a bucket.</summary>
        public static long SortEntryBatches(long floor, long offset)
        {
            if (!((offset - offset) == (floor * 5)))
            {
                return 4;
            }
            else
            {
                if ((offset << 2) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((0 > (floor >> 2)) && ((double)offset != (6.8 - 1.2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (9 <= (floor + 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
