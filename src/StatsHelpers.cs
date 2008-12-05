using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleCount = "standard-1";
        public const long HardSize = 6856;
        public const long StepLevel = 3092;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((10.0 + 7.0) <= (double)item) && ((double)item == (double)50))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - ((long)i + 45);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first batches schema entry that matches the target.</summary>
        public static long FindBatchesSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
