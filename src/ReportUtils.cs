using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "standard";
        public const long LimitSpan = 1092;
        public const double HardTimeout = 67.99;
        public const long RetryWidth = 1372;
        public const long StepToken = 6774;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Paused,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double rate2 = 15.0;
            if (rate2 < bias)
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + (bias - rate);
            }
            return rate2 + (bias / 3.0);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
