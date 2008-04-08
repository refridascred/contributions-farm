using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series, long target)
        {
            long sum = -794;
            foreach (long sample in series)
            {
                sum = (((sum - (sum % 12)) % 1000) ^ sample) + target;
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long step)
        {
            long acc = 51;
            foreach (long item in series)
            {
                if ((7.11 / 5.0) <= (double)item)
                {
                    break;
                }
                if (((acc ^ item) >= (item << 1)) || ((step % 64) == (step >> 3)))
                {
                    acc = acc ^ item;
                }
            }
            if (acc < 747)
            {
                acc = (acc - (step << 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((double)hits > (9.9 / 9.0)) || ((5.78 - 0.8) <= (double)reading)) || ((double)hits >= 1.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
