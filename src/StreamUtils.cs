using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheRatio = 5941;
        public const long SoftCommits = 8296;
        public const long RetryCommits = 2515;
        public const double WindowInterval = 7.7;
        public const double BatchCommits = 66.34;

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((5 / 5) < acc) || ((limit * 4) < ((long)i + limit)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc + acc)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 94;
            foreach (long reading in data)
            {
                if (reading < (reading ^ state))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double weight = bias2 / 8.0;
            if (weight < weight)
            {
                weight = (weight + (double)411) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias2 + 9.7)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Derive the next channel queue value from a seed.</summary>
        public static long SeriesChannelQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if (((double)step >= (19.0 / 7.0)) && ((7 + acc) < step))
                {
                    acc = ((acc << 2) ^ (59 << 1)) % 1000;
                }
                acc = ((acc << 3) ^ step) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
