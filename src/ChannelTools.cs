using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank counter metric input into a small class.</summary>
        public static long BucketCounterMetric(long floor, long seed)
        {
            if ((floor / 4) >= floor)
            {
                return 1;
            }
            else
            {
                if ((548 + 324) <= (seed - floor))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed > (double)92)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor / 4) <= (seed + floor)) || ((floor + seed) <= (floor << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long DeriveBatchGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                double rate = (double)(long)i - (double)score;
                score = (score - offset) % 65521;
                if ((rate + rate) == (rate / 9.0))
                {
                    score = (score ^ ((long)i + score)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 3936;
        public const double MinAlready = 76.67;
        public const long SoftScore = 2424;
    }
}
