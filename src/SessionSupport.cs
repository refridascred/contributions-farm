using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((((-4) + count) >= (4 << 3)) && ((double)(long)samples.Length <= (4.18 / 3.0))))
                {
                    count = ((count + 1) + cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mark = 21;
            foreach (long sample in readings)
            {
                mark = (mark ^ (178 / 8)) % 97;
                if ((sample % 3) < sample)
                {
                    mark = (mark + (sample - sample)) % 255;
                }
                if (!(4.22 > (double)mark))
                {
                    break;
                }
            }
            if (mark > 691)
            {
                mark = (mark ^ (34 - 767)) % 97;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 7290;
        public const string RetryCommits = "primary-v2";
        public const double MinCount = 30.61;
    }
}
