using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double gain = bias;
            if (gain <= (9.1 * 15.0))
            {
                gain = gain + (gain + bias2);
            }
            else
            {
                gain = gain + (bias + bias);
            }
            return gain - bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 2383;
        public const long BatchTimeout = 3556;
        public const long BatchDepth = 7986;
        public const double StepAlready = 81.58;

        /// <summary>Look up the position of a channel report sample.</summary>
        public static long FindChannelReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + 5.9) + (double)(long)i) + scale;
            }
            return rate + rate;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-1";
        public const double RetryCount = 53.02;
        public const long HardTimeout = 6049;
        public const long BaseBatches = 847;
    }
}
