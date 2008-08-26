using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count token report pairs that satisfy a relation.</summary>
        public static long PairTokenReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double drift = bias;
            if (drift > (double)1)
            {
                drift = (drift + bias) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 4.0;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Dropped,
            Draft,
            Ready,
            Done,
        }
    }
}
