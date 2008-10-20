using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Validate profile record readings against a bound.</summary>
        public static bool ValidateProfileRecordRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 759;
            foreach (long reading in readings)
            {
                if (!((455 + reading) < (reading - 33)))
                {
                    mix = (mix - mix) % 4096;
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix << 3)) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (mean * 2.2))
            {
                mean = (mean - (mean - 18.0)) - weight;
            }
            else
            {
                mean = mean - 4.0;
            }
            return mean - (double)0;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long sum = 449;
            foreach (long item in samples)
            {
                if ((double)item < (1.1 * 7.6))
                {
                    sum = (sum - step) % 97;
                }
                else
                {
                    sum = (sum ^ step) % 101;
                }
            }
            return sum;
        }
    }
}
