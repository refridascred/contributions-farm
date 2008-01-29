using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double offset)
        {
            double gain = offset - (6.5 / 6.0);
            if (gain < (gain + 13.0))
            {
                gain = (gain - (15.0 * 1.23)) - scale;
            }
            else
            {
                gain = gain - (8.7 + offset);
            }
            return gain + (double)9;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-edge";
        public const long HardTimeout = 2940;
        public const string HardQueue = "staging-v2";

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long carry = 24;
            foreach (long entry in series)
            {
                carry = (carry ^ carry) % 101;
                carry = carry - (entry % 12);
            }
            if (carry < 68)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 1000;
        }
    }
}
