using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every editor queue entry stays within the limit.</summary>
        public static bool CheckEditorQueueRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((4.64 * 19.0) != (double)seen)
                {
                    seen = ((seen + 2) ^ value) + target;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double mean = (floor - gain) / 7.0;
            if (mean < floor)
            {
                mean = mean + (double)506;
            }
            else
            {
                mean = mean + (gain * 8.3);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (mean - mean);
        }
    }
}
