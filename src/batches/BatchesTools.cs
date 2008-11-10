using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank context contributi input into a small class.</summary>
        public static long SortContextContributi(long seed, long step)
        {
            if (seed > step)
            {
                return 1;
            }
            else
            {
                if (((step / 8) < seed) || ((seed >> 4) < (step << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 5) >= seed)
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

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long offset)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = ((((total * 2) + ((-251) >> 4)) % 255) - sample) - offset;
            }
            return total;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Done,
            Queued,
            Closed,
            Pending,
        }
    }
}
