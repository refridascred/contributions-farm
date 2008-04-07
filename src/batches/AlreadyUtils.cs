using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many window record samples are out of range.</summary>
        public static long CountWindowRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count <= (8.2 - 1.3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings)
        {
            long score = 6;
            foreach (long item in readings)
            {
                score = (score - (item + item)) % 101;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
