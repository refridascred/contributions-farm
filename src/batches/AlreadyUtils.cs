using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long target)
        {
            long delta = limit - target;
            if ((718 + limit) <= (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((delta % 64) >= (8 * 5))
                {
                    return 8;
                }
                else
                {
                    if (!((target >> 2) < 72))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - 546) == (delta - target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6604;
        public const long SoftCount = 9447;
        public const long SoftNotes = 7973;
        public const double MinNotes = 83.42;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items, long limit)
        {
            long mix = 140;
            foreach (long value in items)
            {
                mix = (mix - limit) ^ value;
            }
            return mix % 97;
        }
    }
}
