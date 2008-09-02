using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheWidth = 6519;
        public const double MinAlready = 89.37;
        public const long IdleRatio = 9464;
        public const double BurstAlready = 19.96;

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
