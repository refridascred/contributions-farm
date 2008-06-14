using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two profile entry measurements.</summary>
        public static double ProjectProfileEntry(double scale, double span)
        {
            double ratio = (span + span) + (18.0 - span);
            return ratio + (scale + 0.1);
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long SeekLayoutChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}
