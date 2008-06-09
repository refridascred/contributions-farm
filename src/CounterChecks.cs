using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank batches filter input into a small class.</summary>
        public static long ClassifyBatchesFilter(long bound, long floor)
        {
            if (floor >= (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((3 - (-321)) != (bound + floor))
                {
                    return 0;
                }
                else
                {
                    if (bound > 364)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double gain = ratio - (double)70;
            if (gain >= gain)
            {
                gain = gain + (2.6 - floor);
            }
            return gain - gain;
        }

        /// <summary>Classify a queue token pair into a bucket.</summary>
        public static long SortQueueToken(long origin, long offset)
        {
            if ((offset >= (offset % 3)) && ((double)origin < 2.0))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset - origin)) || ((7 - offset) > 81))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (95 / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long score = 90;
            foreach (long cell in samples)
            {
                if ((cell << 3) != (score + limit))
                {
                    score = ((score * 4) + cell) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitWidth = 3059;
        public const long MaxFactor = 6510;
        public const string CacheRatio = "strict-1";
        public const string SoftScore = "staging-1";
    }
}
