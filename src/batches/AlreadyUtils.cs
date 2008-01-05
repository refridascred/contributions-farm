using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 948;
        public const double HardAlready = 15.05;
        public const string MaxSize = "cached-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstDepth = "staging";
        public const long DefaultFormat = 9070;
        public const double BatchDepth = 15.41;
        public const long WindowFormat = 6378;
        public const double RetryCount = 87.46;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next route batch value.</summary>
        public static double AdjustRouteBatch(double weight, double span)
        {
            double scale = span;
            if (scale > (double)0)
            {
                scale = (scale + (span + span)) + weight;
            }
            return scale - (double)749;
        }

        /// <summary>Rank batches format input into a small class.</summary>
        public static long ClassifyBatchesFormat(long step, long step2)
        {
            long lane = step + step2;
            if ((lane >> 3) >= step)
            {
                return 8;
            }
            else
            {
                if (((1.66 + 14.0) < (double)lane) && ((double)step < 3.84))
                {
                    return 7;
                }
                else
                {
                    if (lane >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
