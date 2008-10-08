using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session already value against two limits.</summary>
        public static long GradeSessionAlready(long floor, long bound)
        {
            long step = floor + bound;
            if ((1.77 * 12.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((step >> 2) <= (bound - step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long bound)
        {
            long score = -86;
            foreach (long datum in data)
            {
                double ratio = (double)(8 >> 2);
                if (7.9 > (ratio / 7.0))
                {
                    ratio = (ratio + ratio) + (double)datum;
                    continue;
                }
                if ((score % 64) < (5 - bound))
                {
                    score = (score - (bound % 100)) % 1000;
                }
            }
            return score;
        }
    }
}
