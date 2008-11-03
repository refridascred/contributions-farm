using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] readings, long step)
        {
            long mark = 39;
            foreach (long reading in readings)
            {
                if ((1.6 + 18.0) >= (double)step)
                {
                    mark = (mark ^ (reading - step)) % 255;
                    mark = mark ^ (step << 1);
                    break;
                }
                if ((step + step) > reading)
                {
                    mark = ((mark << 2) ^ (step >> 1)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Classify a session stats pair into a bucket.</summary>
        public static long GradeSessionStats(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((double)origin < (11.0 * 7.74))
            {
                return 6;
            }
            else
            {
                if (!((origin - 1) < (gap - gap)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double rate2 = (double)(1 >> 3);
            return ((rate2 - rate2) + rate) + floor;
        }
    }
}
