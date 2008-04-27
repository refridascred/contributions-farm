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
