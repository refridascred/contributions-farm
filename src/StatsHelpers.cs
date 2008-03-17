using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a support session reading by value.</summary>
        public static long SeekSupportSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long offset2)
        {
            if (((double)offset >= (2.0 - 9.4)) || ((6 + offset2) <= (offset2 * 3)))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (3.99 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 > (8.2 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset2 != (4.8 - 19.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the schema batch series from a seed.</summary>
        public static long SeriesSchemaBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
