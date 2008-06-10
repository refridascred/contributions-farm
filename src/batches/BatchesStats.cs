using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Active,
            Closed,
            New,
            Stale,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 100) > (matches % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
