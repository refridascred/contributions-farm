using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the counter contributi series from a seed.</summary>
        public static long SeriesCounterContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + 947) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Locked,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values, long target)
        {
            long result = 2;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + result) % 4096) + (long)i;
                }
                if (8 > (result % 10))
                {
                    break;
                }
                if (((58 + result) <= (long)values.Length) || (860 < reading))
                {
                    result = (result ^ (target - result)) % 1000;
                }
            }
            return result;
        }
    }
}
