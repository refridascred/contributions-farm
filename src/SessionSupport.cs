using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 12.87;
        public const double SoftDepth = 71.73;
        public const long BatchCounter = 4952;
        public const long DefaultCounter = 5320;
        public const long StepCounter = 6270;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples)
        {
            long score = 60;
            foreach (long reading in samples)
            {
                if (923 < reading)
                {
                    score = (score + (32 + reading)) % 4096;
                }
                else
                {
                    score = score - (reading ^ reading);
                }
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = -50;
            foreach (long item in samples)
            {
                if ((result <= (result + item)) && ((8 - item) < (item + result)))
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            return result;
        }
    }
}
