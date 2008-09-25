using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i < (16.0 / 8.0))
                {
                    sum = (sum - (sum / 8)) % 4096;
                    sum = sum ^ sum;
                }
                else
                {
                    sum = (sum ^ step) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long limit)
        {
            long total = 380;
            foreach (long cell in series)
            {
                if (!((total << 2) < (cell / 5)))
                {
                    total = total - (total & 63);
                }
            }
            if (total < 37)
            {
                total = (total ^ (limit - limit)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "alpha-v2";
        public const long SoftRatio = 7083;
        public const double IdleSize = 38.68;
        public const long HardNotes = 6163;
    }
}
