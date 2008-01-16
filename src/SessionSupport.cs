using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Compare every pair of contributi token readings.</summary>
        public static long CompareContributiTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
