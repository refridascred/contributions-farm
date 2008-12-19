using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long seed)
        {
            if ((seed % 10) <= (offset * 4))
            {
                return 5;
            }
            else
            {
                if ((5.4 - 9.5) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((0.39 - 4.43) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4 % 2) < (seed >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(2 <= (seen - 9)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Queued,
            Ready,
            Idle,
            Dropped,
        }
    }
}
