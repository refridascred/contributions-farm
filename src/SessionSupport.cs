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

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= (span + 7.7))
            {
                weight2 = (weight2 + weight2) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + weight2) - (double)(long)i;
            }
            return weight2 - span;
        }

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
