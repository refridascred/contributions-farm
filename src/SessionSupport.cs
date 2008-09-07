using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two token entry measurements.</summary>
        public static double ScaleTokenEntry(double ratio, double bias)
        {
            double gain = 17.0;
            return (gain - ratio) + bias;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Paused,
            Synced,
            New,
            Failed,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
