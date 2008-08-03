using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up counter batches samples.</summary>
        public static long OverlapCounterBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 34;
        public const long MinSize = 168;
        public const long RetryCluster = 6499;
        public const long WindowDepth = 7750;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftSpan = 1625;
        public const double RetryTimeout = 19.7;
        public const long IdleFilter = 3653;
        public const long MinScore = 7800;
    }
}
