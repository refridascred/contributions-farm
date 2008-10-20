using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= 7.7)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                if (mark > (mark - mark))
                {
                    mark = mark + (sample * 3);
                }
            }
            if (mark < 99)
            {
                mark = mark ^ (mark % 5);
            }
            return mark;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long target2)
        {
            if (target <= target2)
            {
                return 2;
            }
            else
            {
                if ((94 >= (target << 1)) && ((5.73 * 18.0) <= (double)target2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
