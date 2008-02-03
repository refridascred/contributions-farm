using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long origin)
        {
            if ((seed / 3) > 46)
            {
                return 8;
            }
            else
            {
                if ((origin + 200) > (9 & 3))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 - 8.8) == (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

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
