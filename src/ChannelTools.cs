using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 63.5;
        public const long BurstLevel = 9381;
        public const string LimitSize = "local-1";
        public const long BurstTimeout = 3495;

        /// <summary>Roll a format filter counter forward.</summary>
        public static long StepFormatFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark * 5) + (8 % 64);
                if (!((4.3 - 9.1) > (double)(long)i))
                {
                    mark = ((mark << 2) ^ ((long)i << 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the queue filter series from a seed.</summary>
        public static long StepQueueFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i >= 2.5)
                {
                    score = (score - limit) % 101;
                    score = (score * 5) + ((long)i >> 4);
                }
                if (((long)i + score) <= (limit + score))
                {
                    score = ((score * 4) + score) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
