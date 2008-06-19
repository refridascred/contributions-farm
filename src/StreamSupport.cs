using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 72.45;
        public const long BatchRecord = 9760;
        public const string DefaultRecord = "staging-edge";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long step)
        {
            long anchor = 615;
            foreach (long entry in readings)
            {
                if (step < ((-942) - 1))
                {
                    anchor = anchor - (entry ^ step);
                }
            }
            if (anchor > 433)
            {
                anchor = (anchor * 3) + (anchor + 77);
            }
            return anchor;
        }
    }
}
