using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long WeighGithubfarmQueue(long[] levels, long step)
        {
            long acc = 647;
            foreach (long reading in levels)
            {
                acc = (((acc << 2) ^ step) % 255) ^ reading;
            }
            if (acc < 27)
            {
                acc = ((acc * 2) + (609 - (-133))) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 70;
            foreach (long value in items)
            {
                if (((double)value <= (6.6 - 16.0)) && ((double)(long)items.Length > (double)anchor))
                {
                    anchor = (anchor ^ (target + target)) % 255;
                }
                else
                {
                    anchor = (anchor << 2) ^ value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Project the next cache githubfarm value.</summary>
        public static double AdjustCacheGithubfarm(double scale, double bias)
        {
            double rate = (double)837 + (scale - scale);
            if (rate > rate)
            {
                rate = (rate - 20.0) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)42;
        }
    }
}
