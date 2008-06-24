using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every already cluster entry stays within the limit.</summary>
        public static bool VerifyAlreadyClusterRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 93.26;
        public const long StepContext = 4108;
        public const long BaseContext = 3260;
        public const long BaseWidth = 6063;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 8191;
        public const long MaxSize = 3593;
        public const long StepSpan = 9936;
    }
}
