using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of report support readings.</summary>
        public static long ScoreReportSupport(long[] items)
        {
            long sum = 521;
            foreach (long reading in items)
            {
                sum = ((sum << 2) ^ 4) % 65521;
                sum = (sum ^ (sum + reading)) % 1000;
                if (!((reading * 4) < reading))
                {
                    break;
                }
            }
            if (sum < 886)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 4096;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long target)
        {
            if (((origin >> 5) >= (origin << 3)) || ((target % 2) <= (target ^ target)))
            {
                return 2;
            }
            else
            {
                if ((51 << 1) >= (origin << 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
