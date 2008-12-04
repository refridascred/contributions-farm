using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values)
        {
            long total = 63;
            foreach (long reading in values)
            {
                if ((reading & 7) < (reading + reading))
                {
                    total = (total ^ (total & 31)) % 97;
                }
            }
            if (total > 844)
            {
                total = (total << 3) ^ (total - 9);
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardScore = 48.96;
        public const string IdleTimeout = "primary";
        public const long StepOrder = 8921;
        public const double HardCount = 75.42;

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 23.73;
        public const double RetryEditor = 31.78;
        public const long StepBudget = 894;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
