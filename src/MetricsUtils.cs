using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long result = 10;
            foreach (long entry in values)
            {
                if ((result <= (entry + entry)) && ((entry >> 2) > result))
                {
                    result = (result ^ (result + 97)) % 97;
                }
            }
            if (result < 873)
            {
                result = (result + result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool ValidateToolsLayoutLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long score = 641;
            foreach (long value in data)
            {
                if (floor < (value % 3))
                {
                    score = (score ^ value) % 65521;
                    continue;
                }
                score = ((score << 3) ^ value) % 65521;
                if ((floor >> 3) > 6)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6.0 - 5.9) == (double)origin)
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
