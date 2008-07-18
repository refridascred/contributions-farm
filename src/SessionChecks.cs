using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 6880;
        public const long StepEntry = 7892;
        public const long MinEntry = 7840;
        public const string IdleFactor = "legacy-edge";
        public const long MaxSpan = 4389;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long acc = 279;
            foreach (long item in values)
            {
                acc = (acc - (item & 31)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((35 + target) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Done,
            Queued,
            Dropped,
            Active,
        }
    }
}
