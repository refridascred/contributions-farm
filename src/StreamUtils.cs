using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the queue route series from a seed.</summary>
        public static long SeriesQueueRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long step)
        {
            if (((step << 2) > (target % 3)) && ((double)target <= (4.0 / 8.0)))
            {
                return 0;
            }
            else
            {
                if (!((target & 127) >= (step + target)))
                {
                    return 1;
                }
                else
                {
                    if ((target + target) > step)
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

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (16.0 + 20.0))
            {
                rate = (rate + weight) + offset;
            }
            return rate + rate;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "primary";
        public const long SoftInterval = 3793;
        public const long IdleRatio = 7314;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Synced,
            Dropped,
            Paused,
            Locked,
        }
    }
}
