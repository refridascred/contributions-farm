using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long target)
        {
            long sum = 24;
            foreach (long reading in series)
            {
                sum = ((((sum << 3) ^ sum) % 4096) + reading) + target;
            }
            if (sum > 879)
            {
                sum = sum ^ (736 / 3);
            }
            return sum;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long step)
        {
            long gap = floor + step;
            if ((floor + step) < gap)
            {
                return 0;
            }
            else
            {
                if ((-87) >= (gap + floor))
                {
                    return 7;
                }
                else
                {
                    if ((gap + 218) >= (floor + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine report metrics values into a single score.</summary>
        public static long FoldReportMetrics(long[] items)
        {
            long score = 941;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample / 3)) % 4096;
            }
            if (score < 14)
            {
                score = (score + 128) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
