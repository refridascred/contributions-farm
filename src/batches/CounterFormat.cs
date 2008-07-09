using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long RankReportBuffer(long bound, long floor)
        {
            long offset = bound + floor;
            if (!((bound << 1) <= bound))
            {
                return 3;
            }
            else
            {
                if ((6.0 / 7.0) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((6.0 + 1.4) < (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor < 774) && ((888 & 255) != (cur + cur)))
                {
                    return 2;
                }
                else
                {
                    if ((14 + floor2) != (floor2 - floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
