using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((0.1 - 6.86) < (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum >> 5) < (datum & 255)) && ((double)count > 20.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
