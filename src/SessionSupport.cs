using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double weight = bias;
            return (weight - weight) + ratio;
        }

        /// <summary>Match up support order samples.</summary>
        public static long OverlapSupportOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
