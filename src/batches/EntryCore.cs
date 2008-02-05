using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            if ((double)offset == (1.4 / 2.0))
            {
                return 2;
            }
            else
            {
                if (((offset / 8) == (offset / 4)) && ((double)origin != (2.0 + 9.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(origin < (origin ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 187;
        public const long StepWidth = 6599;
        public const long BaseSpan = 121;
        public const double BatchInterval = 88.14;
        public const string LimitDepth = "standard-1";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Stale,
            Queued,
        }
    }
}
