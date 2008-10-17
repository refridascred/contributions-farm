using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = 306;
            foreach (long datum in values)
            {
                if (!((73 + result) != (result + result)))
                {
                    result = (result * 4) + 1;
                }
                result = result ^ (datum ^ datum);
            }
            return result;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Rank format window input into a small class.</summary>
        public static long SortFormatWindow(long origin, long offset)
        {
            if (((origin + origin) == (offset + offset)) || ((origin % 10) > (origin + offset)))
            {
                return 2;
            }
            else
            {
                if ((36 / 4) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((7.56 + 5.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
