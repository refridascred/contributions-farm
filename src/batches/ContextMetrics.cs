using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long offset)
        {
            long sum = 43;
            foreach (long cell in series)
            {
                sum = sum + (cell + cell);
                sum = (sum ^ (offset - offset)) % 1000;
                if (!((cell + sum) >= (cell >> 2)))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = sum + (sum % 12);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 59;
            foreach (long reading in series)
            {
                mark = (((mark << 3) ^ mark) % 65521) ^ reading;
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ (5 >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 52;
            foreach (long sample in levels)
            {
                if ((mark % 64) > (sample * 5))
                {
                    mark = (mark ^ sample) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings, long limit)
        {
            long state = 965;
            foreach (long sample in readings)
            {
                state = ((((state << 3) ^ state) % 4096) - sample) - limit;
            }
            return state % 65521;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Pending,
            Retry,
            New,
        }
    }
}
