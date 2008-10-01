using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 6298;
        public const long BatchSpan = 6438;
        public const long BaseBuffer = 4202;
        public const double MinBuffer = 3.16;
        public const string BatchBuffer = "open-edge";

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long target)
        {
            long state = 101;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if (((datum + (long)values.Length) != (target - state)) || ((double)datum < (double)state))
                {
                    break;
                }
            }
            if (state > 59)
            {
                state = ((state << 3) ^ (target / 6)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitLevel = "open-edge";
        public const double StepContributi = 20.3;
        public const double LimitContributi = 64.47;
        public const long LimitInterval = 4543;
        public const long LimitFactor = 7208;
    }
}
