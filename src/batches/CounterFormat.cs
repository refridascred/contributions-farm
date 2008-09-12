using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next already token value.</summary>
        public static double SmoothAlreadyToken(double rate, double floor)
        {
            double weight = floor;
            if (weight <= (double)88)
            {
                weight = (weight + (double)6) - rate;
            }
            else
            {
                weight = weight - (double)11;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (1.37 * 1.0)) - (double)(long)i;
            }
            return weight + (weight * 8.2);
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
