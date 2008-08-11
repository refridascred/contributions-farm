using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSpan = 3821;
        public const long WindowAccount = 2821;
        public const double BatchAccount = 88.49;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double scale, double floor)
        {
            double weight = floor;
            if (weight <= weight)
            {
                weight = weight - (scale / 8.0);
            }
            else
            {
                weight = weight + 7.45;
            }
            return weight - (double)31;
        }
    }
}
