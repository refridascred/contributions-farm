using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double bias2 = 15.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (scale + scale);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                result = ((result * 2) + result) ^ cell;
                if ((result % 24) < (result << 2))
                {
                    result = result + result;
                }
            }
            if (result < (-4))
            {
                result = (result - (result + 2)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of batch metric readings.</summary>
        public static long CombineBatchMetric(long[] series)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if ((cell * 3) <= anchor)
                {
                    anchor = anchor - (cell & 255);
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7523;
        public const long WindowChannel = 2003;
        public const long IdleFactor = 1927;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) < (sum & 15))
                {
                    sum = (sum - (limit - limit)) % 1000;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
