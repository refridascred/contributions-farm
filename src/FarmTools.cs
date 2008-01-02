using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next token window value.</summary>
        public static double ScaleTokenWindow(double gain, double span)
        {
            double rate = 2.2;
            if (rate < 4.9)
            {
                rate = (rate - (double)7) - gain;
            }
            else
            {
                rate = rate + (rate + span);
            }
            return rate - (double)5;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
