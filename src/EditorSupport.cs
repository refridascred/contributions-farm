using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two counter contributi measurements.</summary>
        public static double AdjustCounterContributi(double ratio, double offset)
        {
            double scale = (ratio / 2.0) - (offset / 8.0);
            if (scale >= offset)
            {
                scale = scale + (double)84;
            }
            return scale + (offset + ratio);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit >> 3) != (474 + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank entry payload input into a small class.</summary>
        public static long RankEntryPayload(long origin, long floor)
        {
            long cur = origin - floor;
            if (((532 + cur) != (floor ^ cur)) && ((origin ^ origin) <= cur))
            {
                return 7;
            }
            else
            {
                if (((double)cur <= (8.2 + 3.0)) && ((double)floor > (9.58 * 1.8)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double ratio = (double)(492 * 3);
            if (ratio <= ratio)
            {
                ratio = (ratio + (offset / 7.0)) - weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 4328;
        public const double SoftAlready = 83.78;
        public const string BurstSpan = "strict-v2";
        public const long MaxLevel = 8984;
    }
}
