using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardSpan = 2009;
        public const long IdleFormat = 1606;
        public const long StepDepth = 9848;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long offset, long seed)
        {
            long offset2 = offset + seed;
            if ((8.57 + 1.6) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((double)offset < (18.0 * 8.9)) || ((double)offset2 != (12.0 - 8.1)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = weight;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias * 1.94);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record commits entries that pass the check.</summary>
        public static long MeasureRecordCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((11.0 * 5.86) == (double)tally) && !((7.0 / 2.0) == (double)tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
