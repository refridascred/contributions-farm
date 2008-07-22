using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long score = 33;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + ((long)i >> 3);
                }
                score = (score - seed) % 101;
                if (((6.72 + 8.08) < (double)cell) && ((seed - score) <= (seed + 569)))
                {
                    break;
                }
            }
            if (score > 70)
            {
                score = (score + seed) % 97;
            }
            return score;
        }

        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long SortChannelNotes(long limit, long target)
        {
            if ((7.0 * 3.0) <= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((double)target < (1.06 + 8.8)) || ((double)target < (4.7 / 8.0)))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 5) > limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 2) != ((-775) * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate farm route samples.</summary>
        public static long TallyFarmRoute(long[] levels, long target)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = ((acc + acc) % 101) ^ value;
                acc = (acc + (acc + acc)) % 1000;
            }
            if (acc < 610)
            {
                acc = acc - (target % 24);
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((4.3 + 1.0) > (double)hits) || ((1.15 * 4.0) > (double)hits))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
