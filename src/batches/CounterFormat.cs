using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + (gain * 15.0);
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
