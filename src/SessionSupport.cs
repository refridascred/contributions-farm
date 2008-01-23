using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format queue value against two limits.</summary>
        public static long GradeFormatQueue(long seed, long step)
        {
            if ((seed - seed) <= (step + step))
            {
                return 6;
            }
            else
            {
                if ((step <= (seed >> 5)) || ((14.0 / 8.0) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score == (double)(long)i)
                {
                    score = score + (offset - 15);
                    score = (score + score) % 97;
                }
                score = (score * 3) + offset;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
