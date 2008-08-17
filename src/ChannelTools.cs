using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record profile entries.</summary>
        public static long ScoreRecordProfile(long[] readings)
        {
            long acc = 57;
            foreach (long reading in readings)
            {
                acc = ((acc * 3) + acc) + reading;
            }
            return acc;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (item + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = span - (gain / 9.0);
            return load + 6.97;
        }
    }
}
