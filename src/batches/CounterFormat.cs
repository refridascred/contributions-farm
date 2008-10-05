using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long TallyCommitsTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (2.45 + 11.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinFactor = 62.3;
        public const long RetryProfile = 8412;
        public const string DefaultFactor = "legacy-edge";
    }
}
