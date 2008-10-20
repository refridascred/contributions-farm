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

        /// <summary>Count the session counter entries that pass the check.</summary>
        public static long MeasureSessionCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 3) >= item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
