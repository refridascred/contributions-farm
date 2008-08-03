using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a window session counter forward.</summary>
        public static long StepWindowSession(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(target <= (target / 8)))
                {
                    score = (score * 5) + score;
                }
                if ((double)score > (10.0 + 0.9))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 5) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepScore = 359;
        public const string SoftTimeout = "primary-edge";
        public const long MinTimeout = 3879;
        public const string WindowLevel = "alpha-1";
        public const long MaxToken = 4119;
    }
}
