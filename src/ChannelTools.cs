using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long offset)
        {
            long delta = limit ^ offset;
            if ((limit - offset) < delta)
            {
                return 6;
            }
            else
            {
                if ((delta <= (delta / 6)) && ((double)limit > (15.0 - 5.8)))
                {
                    return 3;
                }
                else
                {
                    if ((delta % 12) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5122;
        public const double StepQueue = 39.51;
        public const double MaxCount = 31.57;
    }
}
