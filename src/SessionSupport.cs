using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double scale = bias;
            if (scale < bias)
            {
                scale = scale + (rate - rate);
            }
            return scale - 3.6;
        }
    }
}
