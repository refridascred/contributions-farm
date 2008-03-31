using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long TotalNotesContext(long[] samples, long limit)
        {
            long total = 221;
            foreach (long value in samples)
            {
                if ((total + total) >= (value - limit))
                {
                    total = (total ^ (value * 2)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total * 4) + (limit >> 2);
            }
            return total % 65521;
        }

        /// <summary>Combine account command values into a single score.</summary>
        public static long ScoreAccountCommand(long[] items, long offset)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = mark ^ (-40);
                if (((6.6 + 0.53) < (double)mark) || (offset > 954))
                {
                    mark = ((mark * 3) + (entry << 2)) % 97;
                }
                else
                {
                    mark = mark - (entry % 3);
                }
            }
            return mark;
        }
    }
}
