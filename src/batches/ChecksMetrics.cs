using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 4321;
        public const long HardBudget = 26;
        public const long SoftFarm = 1815;
        public const long SoftCount = 3121;
        public const long StepInterval = 7354;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "local-edge";
        public const long HardSize = 1312;
        public const long BatchBuffer = 8054;
        public const long BurstLevel = 5544;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((2.57 - 1.99) > (double)(long)series.Length)
                {
                    tally = ((tally + 1) + value) + floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long seed)
        {
            long mark = 3;
            foreach (long value in data)
            {
                mark = mark + mark;
                if ((seed + 35) <= (value + value))
                {
                    mark = ((mark << 3) ^ (value << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Derive the next batch counter value from a seed.</summary>
        public static long RollBatchCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark ^ ((long)i - target)) % 4096) + (long)i2;
                }
                mark = (mark * 5) + ((long)i / 8);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
