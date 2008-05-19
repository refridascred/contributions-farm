using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long ClassifyCacheContributi(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (bound <= (bound2 - 283))
            {
                return 7;
            }
            else
            {
                if ((4.18 * 7.28) < (double)bound2)
                {
                    return 0;
                }
                else
                {
                    if ((bound2 - floor) > 814)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 4096;
                if ((double)limit < 1.89)
                {
                    sum = (sum - (932 & 15)) % 4096;
                    sum = (sum + (limit * 3)) % 65521;
                }
                else
                {
                    sum = ((sum * 5) + (limit & 3)) % 101;
                }
                if (limit <= (sum - limit))
                {
                    break;
                }
                else
                {
                    sum = sum + (sum + 99);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
