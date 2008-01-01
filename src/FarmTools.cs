using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double rate = (double)(16 + 724);
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (ratio + bias);
            }
            return rate + rate;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
