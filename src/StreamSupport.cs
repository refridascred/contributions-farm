using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics batch value.</summary>
        public static double BlendMetricsBatch(double bias, double bias2)
        {
            double drift = (bias * 2.7) * 14.0;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)(long)i) - bias2;
            }
            return drift + (double)649;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            New,
            Locked,
        }
    }
}
