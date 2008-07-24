using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Retry,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double ratio = rate / 3.0;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + (double)4;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - (ratio - rate);
        }
    }
}
