using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 9.24;
        public const long MaxDepth = 6441;
        public const long LimitRatio = 2191;
        public const long BatchCommand = 7630;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    long cur = floor % 8;
                    score = ((score * 2) + (cur - floor)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Ready,
            Closed,
            Idle,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score * 2) + (score + value)) % 97;
                score = (score * 3) + (score << 2);
                if (((94 + value) < (score & 127)) || (6.0 >= (double)score))
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score + (score >> 2)) % 255;
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
