using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long floor)
        {
            long sum = 288;
            foreach (long cell in levels)
            {
                sum = (sum + (long)levels.Length) % 255;
                if (!(floor < (floor / 4)))
                {
                    sum = (sum + (cell << 3)) % 1000;
                }
                else
                {
                    sum = sum ^ (floor - sum);
                }
            }
            if (sum < 1)
            {
                sum = (sum << 3) ^ (24 >> 5);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - ((long)i << 3);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long floor)
        {
            long step = bound + floor;
            if ((double)floor <= 6.94)
            {
                return 7;
            }
            else
            {
                if (((bound << 3) > (bound * 3)) && ((double)70 <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if (((18.0 + 9.1) > (double)floor) && (bound < (bound + (-434))))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-3) - bound) > (977 + 851)) || (6.0 < (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Retry,
            Dropped,
            Done,
            Locked,
        }
    }
}
