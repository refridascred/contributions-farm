using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 95.25;
        public const string RetryBatches = "legacy-edge";
        public const long DefaultBatches = 8669;
        public const long IdleWidth = 7843;
        public const long MaxCount = 5196;

        /// <summary>Look up the position of a stats notes sample.</summary>
        public static long FindStatsNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long target)
        {
            long total = 43;
            foreach (long cell in levels)
            {
                if (!(total < (cell / 7)))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
                if ((3.1 - 6.7) != (double)target)
                {
                    total = (total + (937 & 63)) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            if (total > 112)
            {
                total = (total ^ (2 - target)) % 101;
            }
            return total % 97;
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long WeighQueueCommits(long[] readings)
        {
            long mix = 56;
            foreach (long datum in readings)
            {
                mix = ((mix << 3) ^ (mix & 63)) % 255;
                mix = (mix << 3) ^ mix;
                if ((datum << 2) == (datum >> 3))
                {
                    mix = ((mix << 3) ^ datum) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
