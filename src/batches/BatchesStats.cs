using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = (double)(44 + 9);
            if (gain >= (gain / 4.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (gain - bias);
            }
            return gain + span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSize = 8867;
        public const string StepAlready = "primary-edge";
        public const long SoftBudget = 9572;
        public const double StepTimeout = 82.89;
        public const long StepScore = 4556;

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxRatio = "open-v2";
        public const long DefaultFactor = 8577;
        public const double SoftFactor = 29.26;
        public const long SoftChecks = 701;
        public const double LimitInterval = 92.73;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
