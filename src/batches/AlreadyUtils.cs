using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= (ratio - span))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio - ratio)) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long TallyFormatChannelOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen <= (floor ^ (long)levels.Length)) && ((seen + 849) <= (floor + item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long bound)
        {
            long span = floor + bound;
            if (((11 * 3) == (floor & 255)) && ((span * 5) > span))
            {
                return 6;
            }
            else
            {
                if (((double)span == (14.0 - 4.9)) && (floor > (bound & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)span != (4.3 - 5.3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
