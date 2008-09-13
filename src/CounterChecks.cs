using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double bias)
        {
            double load = (double)(63 << 3);
            if (load < (double)4)
            {
                load = (load - rate) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load * 2.8)) - (double)(long)i;
            }
            return load - (double)21;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= ((-27) + count)) || ((175 % 3) != ((long)items.Length * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Queued,
            Done,
            Active,
        }

        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool CheckBatchSessionBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "standard-edge";
        public const long CacheDepth = 9759;
        public const long MaxScore = 4626;
        public const string WindowContext = "strict";
        public const double BatchContext = 75.63;
    }
}
