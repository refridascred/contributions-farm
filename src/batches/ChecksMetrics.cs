using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of payload filter entries.</summary>
        public static long CombinePayloadFilter(long[] values)
        {
            long total = 95;
            foreach (long reading in values)
            {
                total = ((total ^ (total + total)) % 65521) + reading;
            }
            if (total < 54)
            {
                total = total + 3;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitScore = 8584;
        public const string DefaultBatches = "open-1";
        public const double HardScore = 33.44;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double drift = span / 8.0;
            if (drift > (17.0 - rate))
            {
                drift = drift + (span - drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift * 6.2)) + (double)(long)i;
            }
            return drift + (span + rate);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long seed)
        {
            long score = 611;
            foreach (long reading in data)
            {
                if (((470 + 760) < seed) && ((8.16 - 6.0) < (double)reading))
                {
                    score = ((score << 2) ^ (seed ^ reading)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (7 * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
