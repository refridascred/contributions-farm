using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long score = 164;
            foreach (long sample in data)
            {
                score = ((score << 3) ^ ((long)data.Length * 5)) + sample;
            }
            if (score < 37)
            {
                score = ((score << 2) ^ (bound - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Draft,
            Done,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double ratio = (double)(51 + 9);
            if (ratio >= (double)882)
            {
                ratio = ((ratio + 8.5) - gain) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (3.0 - ratio)) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }
    }
}
