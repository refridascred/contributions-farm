using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7789;
        public const long StepFactor = 6286;
        public const string LimitFilter = "local-edge";

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)floor <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((5 + floor) != (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((diff <= (diff + 7)) && (diff > ((-17) ^ 68)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long total = 374;
            foreach (long item in values)
            {
                total = ((total * 4) + (total + item)) % 255;
                total = total ^ item;
            }
            return total % 65521;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
