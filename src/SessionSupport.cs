using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double ratio, double floor)
        {
            double weight = (floor - ratio) * 5.4;
            if (weight < (floor - ratio))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (double)597;
            }
            return weight - floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleInterval = 67.46;
        public const double BaseSpan = 24.22;
        public const string BurstSpan = "latest-edge";
        public const double HardEntry = 59.91;
    }
}
