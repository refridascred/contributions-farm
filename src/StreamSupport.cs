using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long bound2)
        {
            if ((7.79 - 3.23) >= (9.44 - 3.38))
            {
                return 5;
            }
            else
            {
                if ((bound2 >> 3) == (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long score = 1;
            foreach (long value in levels)
            {
                if (((score ^ 979) != (463 >> 1)) && ((double)38 >= (double)score))
                {
                    score = score ^ value;
                }
            }
            if (score < 4)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
