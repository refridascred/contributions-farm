using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)hits >= (8.1 + 3.4)) && ((6.7 + 3.3) <= (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 10.37;
        public const long IdleSize = 5972;
        public const long WindowLevel = 5119;
        public const long BurstCommits = 6081;
        public const string LimitWidth = "open";

        /// <summary>Validate order batches readings against a bound.</summary>
        public static bool ValidateOrderBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long score = 615;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) == (536 + item))
                {
                    score = (score + (score << 1)) % 1000;
                    score = ((score * 5) + (item + score)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (item + 6)) % 4096;
                }
                score = (score ^ item) % 1000;
            }
            if (score > 982)
            {
                score = ((score * 4) + (score ^ score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double load = (bias2 - 0.3) - (double)3;
            if (load < bias)
            {
                load = load - 4.63;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(-3)) + (double)(long)i;
            }
            return load + bias2;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
