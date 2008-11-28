using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long limit)
        {
            long state = 119;
            foreach (long sample in series)
            {
                state = (state - state) - sample;
                state = ((state << 2) ^ (limit - state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i == ((long)i + bound)) && (((long)i + 63) > (long)i)))
                {
                    anchor = ((anchor * 5) + ((long)i - bound)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
