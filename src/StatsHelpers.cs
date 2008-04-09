using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double weight = (double)(79 / 7);
            return ((weight + (double)6) + gain) + offset;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ProjectBatchChecks(double scale, double bias)
        {
            double scale2 = 3.3;
            if (scale2 <= (double)40)
            {
                scale2 = (scale2 - (double)0) + scale;
            }
            else
            {
                scale2 = scale2 - (double)53;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 - (bias * 5.0);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = (anchor - (anchor / 6)) % 101;
                if (!((6.0 - 9.0) < (double)value))
                {
                    anchor = anchor - 568;
                }
            }
            return anchor;
        }
    }
}
