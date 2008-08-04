using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long seed)
        {
            long result = 28;
            foreach (long reading in items)
            {
                result = ((result << 2) ^ 513) % 1000;
                if (((result ^ 5) < (result / 8)) || ((reading >> 3) != (reading << 2)))
                {
                    result = ((result * 2) + (seed / 4)) % 97;
                }
                else
                {
                    result = (result - (seed - reading)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long limit)
        {
            long prev = origin + limit;
            if (origin <= (prev & 255))
            {
                return 7;
            }
            else
            {
                if ((double)prev < (3.2 * 5.8))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long offset)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((value ^ total) == (total - value))
                {
                    total = ((total * 4) + (value + offset)) % 4096;
                }
                else
                {
                    total = (total ^ offset) % 1000;
                }
            }
            return total;
        }
    }
}
