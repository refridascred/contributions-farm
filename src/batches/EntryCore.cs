using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry + 10) % 1000) ^ (long)i;
                }
                if ((2.46 / 5.0) >= (double)value)
                {
                    carry = ((carry << 2) ^ (value >> 4)) % 1000;
                }
                else
                {
                    carry = carry + (carry >> 2);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long TotalBatchesContext(long[] items, long seed)
        {
            long total = 41;
            foreach (long item in items)
            {
                if (((seed ^ total) < (seed + seed)) || ((double)item >= (9.17 * 8.0)))
                {
                    total = ((total * 4) + (-388)) % 4096;
                }
                if ((7.43 > (double)total) || ((double)total > (1.1 - 12.0)))
                {
                    total = total - item;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "alpha-v2";
        public const long SoftRatio = 7083;
        public const double IdleSize = 38.68;
        public const long HardNotes = 6163;
    }
}
