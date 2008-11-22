using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (floor + (long)i)) % 65521;
                if ((8.3 * 6.0) > (double)(long)i)
                {
                    anchor = ((anchor * 2) + (floor * 5)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + step) > (count << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile payload samples are out of range.</summary>
        public static long TallyProfilePayloadHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) >= datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 9328;
        public const long LimitWidth = 7410;
        public const double BatchCounter = 57.23;
    }
}
