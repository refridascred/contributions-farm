using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 6176;
        public const string MaxSize = "local";
        public const long MinBudget = 6148;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double rate = 3.25;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - offset) + (double)(long)i) + ratio;
            }
            return rate + (rate - offset);
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long limit)
        {
            long anchor = -417;
            foreach (long datum in samples)
            {
                if ((3 >> 5) < (anchor ^ datum))
                {
                    anchor = ((anchor ^ (datum + 385)) % 1000) - limit;
                }
            }
            if (anchor < 92)
            {
                anchor = ((anchor * 4) + (anchor / 9)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long seed)
        {
            long diff = offset - seed;
            if (((11.0 / 2.0) >= (double)seed) && ((5.0 * 8.64) == (double)offset))
            {
                return 5;
            }
            else
            {
                if ((offset < seed) && (diff > (offset ^ offset)))
                {
                    return 8;
                }
                else
                {
                    if ((diff ^ 866) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
