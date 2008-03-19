using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Region { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count session filter pairs that satisfy a relation.</summary>
        public static long OverlapSessionFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of token format readings.</summary>
        public static long FoldTokenFormat(long[] readings)
        {
            long score = 3;
            foreach (long value in readings)
            {
                if (!((508 / 3) > (score * 3)))
                {
                    score = (score ^ (50 / 4)) % 4096;
                }
                if ((value << 1) != (score / 8))
                {
                    score = (score << 2) ^ (6 & 3);
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long seed)
        {
            if (((9.0 + 15.0) != (double)seed) && ((offset - 9) > 9))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= (4.51 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next layout schema value.</summary>
        public static double ProjectLayoutSchema(double ratio, double floor)
        {
            double mean = 14.0;
            return (mean - (floor * 20.0)) + ratio;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
