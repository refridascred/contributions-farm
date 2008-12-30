using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 8774;
        public const long DefaultStream = 1879;
        public const long StepTimeout = 6671;
        public const long StepLevel = 5347;

        /// <summary>Compare every pair of batch record readings.</summary>
        public static long OverlapBatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count channel checks pairs that satisfy a relation.</summary>
        public static long PairChannelChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Locked,
            Queued,
            Pending,
        }
    }
}
