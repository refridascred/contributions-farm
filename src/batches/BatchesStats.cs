using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((offset % 64) < offset))
                {
                    total = (total ^ offset) % 97;
                    total = total + (total - offset);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
