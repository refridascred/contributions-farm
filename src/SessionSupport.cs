using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Paused,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double bias2 = (double)((-155) >> 5);
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)(long)i) - rate;
            }
            return bias2 - (bias + bias);
        }
    }
}
