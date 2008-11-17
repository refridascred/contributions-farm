using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((63 % 24) == (cell / 5)) || !((cell + count) <= (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long offset)
        {
            if ((3.76 * 3.92) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((limit + limit) >= (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (offset % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count / 8) > (reading * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
