using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool VerifyFarmBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state - (long)i;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long MeasureBufferWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > 5.74) || (((double)sample <= 5.0) || ((sample + sample) >= (hits >> 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
