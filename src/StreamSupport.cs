using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate account counter readings against a bound.</summary>
        public static bool GuardAccountCounterRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
