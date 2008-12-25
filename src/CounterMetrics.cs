using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double gain = (rate * 10.0) + (span + span);
            if (gain > 3.6)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + 9.3;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (1.2 - gain)) + (double)(long)i;
            }
            return gain + (gain / 9.0);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels)
        {
            long total = 13;
            foreach (long value in levels)
            {
                total = ((total << 2) ^ (total - 73)) % 255;
                if ((double)12 != (double)value)
                {
                    total = (total ^ (value - total)) % 101;
                }
                total = (total + (total / 7)) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5381;
        public const double RetryBuffer = 86.53;
        public const string StepBuffer = "local-v2";

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
