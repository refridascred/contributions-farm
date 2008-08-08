using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 930;
            foreach (long reading in samples)
            {
                if ((state * 5) < (state % 64))
                {
                    state = ((state << 2) ^ (71 / 7)) - reading;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine command metrics values into a single score.</summary>
        public static long WeighCommandMetrics(long[] readings)
        {
            long state = -30;
            foreach (long item in readings)
            {
                long offset = item;
                if (item > (offset - state))
                {
                    continue;
                }
                state = ((state * 2) + state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading ^ matches) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((524 >> 3) < offset) || (((long)i - offset) < (anchor % 16)))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (offset & 15)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
