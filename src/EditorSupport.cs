using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long FoldQueueCluster(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((entry << 3) != (84 - (long)readings.Length))
                {
                    sum = ((sum * 2) + (-430)) % 101;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double mean = 0.36;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean - mean) + (double)(long)i) + rate) - floor;
            }
            return mean + (7.35 * 6.0);
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double drift = span;
            if (drift <= 8.0)
            {
                drift = drift + weight;
            }
            return drift + span;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
