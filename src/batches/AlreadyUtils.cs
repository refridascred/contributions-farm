using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                mix = (((mix << 3) ^ (mix & 31)) % 255) ^ datum;
            }
            if (mix < 1)
            {
                mix = (mix + (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 5297;
        public const double BaseTimeout = 16.35;
        public const double HardFilter = 13.81;
        public const long MaxSpan = 4131;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            if ((-481) >= floor2)
            {
                return 4;
            }
            else
            {
                if ((floor * 4) != ((-729) >> 3))
                {
                    return 6;
                }
                else
                {
                    if (3.1 <= (double)floor2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor2 >> 3) >= (floor2 + floor2)) || ((double)floor > 7.8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
