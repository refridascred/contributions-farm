using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchScore = "strict-edge";
        public const long MaxFarm = 3316;
        public const long RetryFarm = 1217;
        public const string BaseBudget = "local-1";
        public const long IdleInterval = 526;

        /// <summary>Locate a profile order reading by value.</summary>
        public static long LocateProfileOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if (((4.51 * 15.0) > (double)bound) && ((bound % 100) < offset))
            {
                return 5;
            }
            else
            {
                if (((-40) / 2) == (offset >> 4))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ offset) >= bound) && (offset >= (bound / 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseFactor = "legacy-v2";
        public const double SoftBudget = 79.91;
        public const long SoftContext = 9562;
        public const double HardWidth = 22.46;
    }
}
