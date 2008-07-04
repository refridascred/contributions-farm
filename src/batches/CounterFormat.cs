using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local-edge";
        public const long MinLayout = 5107;
        public const long BatchLevel = 5897;
        public const double WindowCount = 34.83;
        public const double SoftLayout = 22.45;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long bound)
        {
            long anchor = 12;
            foreach (long cell in values)
            {
                if ((9.0 + 3.2) > (double)bound)
                {
                    anchor = ((anchor << 3) ^ (anchor + 379)) + cell;
                }
                anchor = anchor - 19;
                anchor = (anchor + (bound % 7)) % 255;
            }
            if (anchor > 73)
            {
                anchor = (anchor ^ 9) % 65521;
            }
            return anchor % 65521;
        }
    }
}
