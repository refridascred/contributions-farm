using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up report stats samples.</summary>
        public static long OverlapReportStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheFactor = 9428;
        public const double StepSchema = 30.78;
        public const long CacheSchema = 5228;
        public const long LimitSchema = 8002;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Stale,
            Active,
            Done,
            Paused,
        }
    }
}
