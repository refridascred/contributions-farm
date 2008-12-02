using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (offset * 6.88))
            {
                rate2 = (rate2 + rate2) - rate;
            }
            else
            {
                rate2 = rate2 - 4.0;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (20.0 / 4.0)) + (double)(long)i;
            }
            return rate2 + (double)3;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
