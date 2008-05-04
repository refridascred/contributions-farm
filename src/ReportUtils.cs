using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Adjust a order schema reading.</summary>
        public static double ProjectOrderSchema(double weight, double offset)
        {
            double gain = 9.72;
            if (gain >= 17.0)
            {
                gain = ((gain + (double)(-401)) - weight) + offset;
            }
            else
            {
                gain = gain + 7.0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (3.48 / 3.0);
        }

        /// <summary>Project the next buffer report value.</summary>
        public static double BlendBufferReport(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + 4.9) - (double)(long)i) - bias2;
            }
            return gain + (2.0 - gain);
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long PairQueueBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long offset, long step)
        {
            if (step <= (67 + 389))
            {
                return 3;
            }
            else
            {
                if (((offset / 4) != (step + step)) && ((4.0 * 9.0) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
