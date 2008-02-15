using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every filter account entry stays within the limit.</summary>
        public static bool VerifyFilterAccountBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double weight = (double)(841 - 311);
            if (weight > weight)
            {
                weight = (weight + (rate * 8.69)) - floor;
            }
            else
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - 5.0;
        }
    }
}
