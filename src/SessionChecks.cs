using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (acc > (offset >> 4))
                {
                    acc = ((acc * 5) + (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double weight = scale;
            if (weight > (7.7 + weight))
            {
                weight = weight + (scale - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (bias * 1.0);
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                sum = (sum + (step - (-543))) ^ cell;
                if ((9 + step) == (step & 15))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
