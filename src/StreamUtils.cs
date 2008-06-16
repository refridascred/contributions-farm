using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "stable";
        public const long MinContext = 8547;
        public const long LimitContext = 6115;
        public const long StepScore = 1391;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long cell in samples)
            {
                if (offset < (cell ^ offset))
                {
                    anchor = ((anchor << 3) ^ (cell ^ cell)) % 97;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor + (offset - offset)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 9655;
        public const long StepContext = 1203;
        public const long BurstContext = 8210;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long next = origin + floor;
            if (((floor + next) < next) && ((origin + origin) >= next))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 7.0) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((2.3 / 8.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double rate = (double)(18 - 73);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (9.2 - gain);
        }
    }
}
