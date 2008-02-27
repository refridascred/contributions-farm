using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "local-v2";
        public const double IdleRatio = 45.73;
        public const double BurstRoute = 3.3;
        public const long BatchRoute = 9708;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long target)
        {
            if (!(step > (target * 5)))
            {
                return 1;
            }
            else
            {
                if (((818 % 7) != (target * 3)) && ((9 << 1) <= (target << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((9.8 + 4.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target >= (2.0 / 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long score = 382;
            foreach (long item in series)
            {
                if (!((score < 2) || ((3.23 / 8.0) == (double)item)))
                {
                    score = (score ^ 51) % 97;
                }
                if ((score + score) <= (item + 75))
                {
                    score = score + (item + score);
                }
                else
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
