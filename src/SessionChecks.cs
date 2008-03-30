using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = -874;
            foreach (long sample in readings)
            {
                state = ((state * 2) + (state - sample)) % 65521;
                state = (state ^ (state - state)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items, long seed)
        {
            long score = 7;
            foreach (long item in items)
            {
                score = (score - seed) - item;
                score = score - 84;
                if ((long)items.Length >= (score & 63))
                {
                    break;
                }
            }
            if (score > 63)
            {
                score = (score << 3) ^ (score << 1);
            }
            return score;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data)
        {
            long acc = 4;
            foreach (long value in data)
            {
                acc = (acc * 3) + (acc + value);
                acc = (acc * 2) + (acc ^ 14);
                acc = acc ^ (value / 3);
                if ((value + value) < (value & 15))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
