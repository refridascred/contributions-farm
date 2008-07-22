using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)floor <= 2.91)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream support readings.</summary>
        public static long OverlapStreamSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 1235;
        public const string MaxInterval = "staging-v2";
        public const string MaxCommand = "stable-1";
        public const long StepLevel = 3376;
        public const long IdleCommand = 6694;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 9883;
        public const double IdleBatches = 73.5;
        public const long BurstTimeout = 9997;
    }
}
