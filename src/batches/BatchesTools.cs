using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state + (floor / 9)) % 1000) + (long)i2;
                }
                state = ((state << 2) ^ (state + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            New,
            Closed,
            Synced,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double mean = (double)(59 / 2);
            if (mean > 0.7)
            {
                mean = ((mean + mean) - ratio) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + mean)) - (double)(long)i;
            }
            return mean - (mean - 5.0);
        }
    }
}
