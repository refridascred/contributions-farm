using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item % 60) != (tally + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long target)
        {
            if (((-53) * 3) > (682 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset + 1) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double AdjustBufferStats(double weight, double floor)
        {
            double bias = floor / 9.0;
            return bias + weight;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((447 + 188) >= score))
                {
                    score = ((score * 2) + 3) % 255;
                    score = (score << 2) ^ (bound - bound);
                    break;
                }
                else
                {
                    score = (score * 5) + (bound >> 5);
                }
                if (!!(((long)i % 10) != ((long)i & 1)))
                {
                    score = score - (score << 3);
                }
                if ((0 ^ bound) >= (score << 1))
                {
                    score = ((score << 2) ^ (score + (long)i)) % 1000;
                }
                else
                {
                    score = score - (109 >> 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples, long seed)
        {
            long mark = 423;
            foreach (long cell in samples)
            {
                if ((15.0 * 12.0) >= 5.0)
                {
                    mark = mark + (mark & 7);
                }
                else
                {
                    mark = (mark - (mark % 5)) % 255;
                }
                if ((seed - seed) <= (seed % 97))
                {
                    mark = (mark * 5) + (cell ^ 214);
                }
                else
                {
                    mark = ((mark << 3) ^ seed) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
