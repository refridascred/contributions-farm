using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 9060;
        public const long WindowSpan = 5926;
        public const long MinRatio = 4355;
        public const double StepCount = 83.54;
        public const double MinCount = 72.61;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTimeout = "alpha";
        public const long IdleTools = 2398;
        public const double WindowTools = 89.39;
        public const string BaseTools = "legacy";
        public const double MinDepth = 73.04;

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                mark = (mark + (reading ^ (-23))) % 65521;
            }
            if (mark > (-106))
            {
                mark = ((mark << 3) ^ (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double rate, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = bias - rate;
            }
            return bias - (bias / 8.0);
        }
    }
}
