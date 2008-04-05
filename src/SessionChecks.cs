using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4748;
        public const double StepTools = 26.2;
        public const long BurstTools = 384;

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double bias)
        {
            double load = (double)39;
            if (load >= (load / 5.0))
            {
                load = (load + ratio) - bias;
            }
            else
            {
                load = load + (double)187;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Draft,
            Dropped,
            Locked,
            Synced,
        }
    }
}
