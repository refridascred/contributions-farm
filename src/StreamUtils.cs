using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4375;
        public const long HardSize = 945;
        public const long BatchBudget = 3221;

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double gain = (scale * 16.0) - (double)5;
            if (gain < (scale / 4.0))
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + gain)) + (double)(long)i;
            }
            return gain + (double)246;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2089;
        public const double StepSession = 19.26;
        public const long WindowBudget = 4386;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
