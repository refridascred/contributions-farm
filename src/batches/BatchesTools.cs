using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if ((sum - 11) > (sum + 9))
                {
                    sum = (sum ^ (cell - 50)) % 255;
                }
                else
                {
                    sum = sum - cell;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum * 4) < (target % 7)) && (((double)matches <= (2.6 + 4.6)) || ((matches ^ matches) > (7 + matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
