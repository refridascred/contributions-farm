using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double mean = rate;
            return (mean - rate) + offset;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((17 / 3) <= bound))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long target)
        {
            if (target <= step)
            {
                return 7;
            }
            else
            {
                if ((target << 2) == (7 + target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data)
        {
            long mark = 748;
            foreach (long datum in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark << 2) ^ (datum + 913)) + (long)i;
                    mark = ((mark * 3) + mark) % 97;
                }
                if ((mark << 3) < (mark / 4))
                {
                    mark = (mark ^ (mark - mark)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2819;
        public const string WindowRatio = "primary-edge";
        public const long RetrySize = 2093;
        public const long LimitSpan = 5485;
    }
}
