using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7938;
        public const long DefaultScore = 8796;
        public const long HardContributi = 1065;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long acc = 57;
            foreach (long datum in items)
            {
                acc = (((acc * 3) + (26 << 1)) % 65521) ^ datum;
            }
            return acc % 4096;
        }
    }
}
