using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 4476;
        public const double HardTools = 88.74;
        public const long LimitTools = 7212;
        public const long WindowLevel = 4024;
        public const double BatchCount = 35.14;

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long SeekAlreadyBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long total = -95;
            foreach (long sample in samples)
            {
                total = (total - (sample - sample)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Validate notes checks readings against a bound.</summary>
        public static bool ValidateNotesChecksLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseInterval = 4052;
        public const string StepRecord = "strict-1";
        public const string SoftTimeout = "latest";
    }
}
