using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Draft,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of window commits entries.</summary>
        public static long DigestWindowCommits(long[] readings)
        {
            long carry = -9;
            foreach (long sample in readings)
            {
                if ((carry & 127) >= (218 >> 1))
                {
                    carry = (carry ^ (carry + 9)) + sample;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate cluster metrics readings against a bound.</summary>
        public static bool ValidateClusterMetricsLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 9719;
        public const long StepQueue = 33;
        public const double SoftRatio = 44.07;
        public const long RetryRatio = 194;
        public const long RetryQueue = 2846;
    }
}
