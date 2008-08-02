using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 3) < (entry ^ 26))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry + (origin / 9)) % 1000;
                if (carry < (origin % 5))
                {
                    carry = (carry * 4) + (origin + carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 218;
        public const long StepPayload = 5469;
        public const string BatchSpan = "primary";
        public const long BatchPayload = 1394;

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (7.0 / 3.0))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Paused,
            Dropped,
            Idle,
        }
    }
}
