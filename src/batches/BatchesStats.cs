using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2 * 3) == (reading / 7))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mark = -95;
            foreach (long cell in values)
            {
                mark = mark - (cell + cell);
            }
            if (mark > 967)
            {
                mark = ((mark * 4) + (mark * 5)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Blend two commits tools measurements.</summary>
        public static double AdjustCommitsTools(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < (bias - scale))
            {
                scale = scale - (bias2 + bias2);
            }
            else
            {
                scale = scale + (11.0 + scale);
            }
            return scale - (bias / 9.0);
        }
    }
}
