using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double rate = (floor - scale) + floor;
            if (rate <= floor)
            {
                rate = rate - 2.7;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor + floor);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 - 1.12) != (double)target)
                {
                    total = (total * 4) + (total + total);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 4736;
        public const string BaseCommits = "cached-v2";
        public const double WindowCommits = 37.62;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 7402;
        public const long IdleLevel = 6155;
        public const double MinScore = 73.31;

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long score = 63;
            foreach (long sample in levels)
            {
                if ((score >> 2) == (sample - 91))
                {
                    score = ((score * 4) + (sample << 1)) % 1000;
                    score = (score ^ (93 << 1)) % 65521;
                }
                if (sample > (score + score))
                {
                    score = (score - (27 - target)) % 4096;
                }
                else
                {
                    score = (score ^ (sample % 100)) % 255;
                }
                if ((score / 4) != (target + score))
                {
                    break;
                }
            }
            if (score > 228)
            {
                score = (score - (target * 5)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
