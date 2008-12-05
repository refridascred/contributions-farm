using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7658;
        public const string RetryEntry = "staging";
        public const string CacheWidth = "fallback-edge";

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (9.9 * 13.0))
            {
                bias2 = bias2 + (7.34 - bias);
            }
            return bias2 + (bias * 13.0);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 4) + ((long)i << 3);
                if (floor <= (floor * 4))
                {
                    score = score ^ ((long)i >> 5);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
