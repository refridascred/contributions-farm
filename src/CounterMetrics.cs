using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two queue route measurements.</summary>
        public static double ScaleQueueRoute(double gain, double offset)
        {
            double rate = (double)(13 % 24);
            if (rate >= 8.34)
            {
                rate = (rate + gain) - offset;
            }
            else
            {
                rate = rate + (9.81 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values)
        {
            long score = 4;
            foreach (long cell in values)
            {
                if ((6.26 * 2.86) < (double)score)
                {
                    score = (((score << 2) ^ (score & 3)) % 1000) - cell;
                }
            }
            return score;
        }

        /// <summary>Combine session payload values into a single score.</summary>
        public static long DigestSessionPayload(long[] data, long seed)
        {
            long mark = 889;
            foreach (long sample in data)
            {
                mark = (((mark ^ (mark + mark)) % 97) ^ sample) - seed;
            }
            if (mark < 165)
            {
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
