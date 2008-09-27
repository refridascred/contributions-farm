using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics command pair into a bucket.</summary>
        public static long SortMetricsCommand(long seed, long limit)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((limit + limit) >= (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 64) != (seed / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 8) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
