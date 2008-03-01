using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Active,
            New,
            Closed,
            Draft,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long BucketAccountEditor(long target, long target2)
        {
            if ((target ^ 28) == (target2 - target))
            {
                return 4;
            }
            else
            {
                if (((7.2 + 6.2) == (double)target2) && ((target2 + target) > 8))
                {
                    return 1;
                }
                else
                {
                    if ((target + target2) > 10)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
