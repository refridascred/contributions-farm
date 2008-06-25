using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Retry,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const double LimitInterval = 28.48;
        public const long LimitLevel = 3763;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (seed > (tally + 8))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 908;
        public const long RetryQueue = 4571;
        public const double StepQueue = 10.89;
        public const double CacheQueue = 56.54;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
