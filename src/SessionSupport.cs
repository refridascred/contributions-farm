using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 40.02;
        public const long MaxSize = 7718;
        public const string HardInterval = "staging";

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (offset2 > 65)
            {
                return 6;
            }
            else
            {
                if (!((offset + offset2) == (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 8) > offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((score < (0 + score)) || ((datum & 3) > (datum - score)))
                {
                    score = (score << 2) ^ datum;
                }
                else
                {
                    score = (score - (35 ^ 766)) % 4096;
                }
                if ((datum + score) > (datum / 9))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = (score - 6) % 65521;
            }
            return score;
        }
    }
}
