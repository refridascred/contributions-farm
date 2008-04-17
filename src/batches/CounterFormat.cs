using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((floor < (9 - 570)) && ((9 * 3) > (cell - (-31))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i <= offset))
                {
                    sum = (sum * 4) + (sum ^ sum);
                }
                if ((double)sum == (double)offset)
                {
                    sum = (sum ^ (offset ^ (-41))) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
