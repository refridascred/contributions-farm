using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 92;
            foreach (long entry in values)
            {
                if ((double)0 == (double)entry)
                {
                    state = ((state << 3) ^ (7 << 2)) % 4096;
                }
                if (!((1.28 - 9.2) == (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score > (6.0 * 9.44))
                {
                    score = ((score * 5) + ((-34) + score)) % 97;
                }
                if (!((double)score == (6.91 + 7.78)))
                {
                    score = (score + (score * 2)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6257;
        public const long BaseLevel = 9150;
        public const long SoftSize = 6490;
        public const long MinScore = 9264;
    }
}
