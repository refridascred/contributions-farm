using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long floor)
        {
            long mix = 73;
            foreach (long entry in samples)
            {
                mix = mix - ((-904) + floor);
                if ((entry ^ 507) != (floor & 15))
                {
                    mix = mix ^ (mix + 1);
                }
            }
            if (mix < 719)
            {
                mix = (mix + floor) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Retry,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Retry,
        }
    }
}
