using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items)
        {
            long acc = 19;
            foreach (long sample in items)
            {
                if (!((408 + sample) <= (acc >> 4)))
                {
                    acc = (acc - (acc / 8)) % 65521;
                }
            }
            if (acc < 99)
            {
                acc = (acc - ((long)items.Length & 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Validate metrics stats readings against a bound.</summary>
        public static bool ValidateMetricsStatsRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of account cache entries.</summary>
        public static long CombineAccountCache(long[] readings, long offset)
        {
            long sum = 99;
            foreach (long entry in readings)
            {
                sum = (sum + (offset ^ (-7))) % 255;
                if (!(((long)readings.Length + 92) <= offset))
                {
                    sum = (sum - (-1)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (sum - entry)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Blend two farm commits measurements.</summary>
        public static double ScaleFarmCommits(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (10.0 / 2.0))
            {
                mean = mean - (double)5;
            }
            else
            {
                mean = mean - (bias - 16.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 4.7) + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
