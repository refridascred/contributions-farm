using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 4745;
        public const double BatchSpan = 16.25;
        public const long CacheQueue = 4136;
        public const long SoftQueue = 649;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 7.9;
        public const double HardFarm = 65.2;
        public const string BurstFarm = "open-edge";

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long origin)
        {
            long step = target - origin;
            if ((target >> 2) <= (step >> 5))
            {
                return 5;
            }
            else
            {
                if (!((step ^ 77) < 2))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) <= 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin > target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
