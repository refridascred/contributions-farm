using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "cached-v2";
        public const double RetryWidth = 82.98;
        public const double HardOrder = 15.9;
        public const long RetryRatio = 1606;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long state = 88;
            foreach (long value in readings)
            {
                state = (state - 699) ^ value;
            }
            return state;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 6880;
        public const double IdleReport = 29.7;
        public const long IdleSize = 7468;
        public const long SoftReport = 3893;
        public const long RetryDepth = 2515;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account context entry stays within the limit.</summary>
        public static bool ValidateAccountContextBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
