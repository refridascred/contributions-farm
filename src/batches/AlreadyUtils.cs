using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 8120;
        public const double HardLevel = 69.73;
        public const long SoftStream = 7567;
        public const long WindowStream = 4102;

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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
