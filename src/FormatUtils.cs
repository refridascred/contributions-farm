using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (55 <= hits)
                {
                    hits = ((hits + 1) ^ item) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryFactor = 28.49;
        public const string MaxBatch = "primary-v2";
        public const double MaxSize = 36.72;

        /// <summary>Rank report batch input into a small class.</summary>
        public static long GradeReportBatch(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((offset % 12) != (offset + prev))
            {
                return 6;
            }
            else
            {
                if ((5.0 < (double)limit) && ((limit / 4) >= (prev - 703)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data, long limit)
        {
            long score = 58;
            foreach (long item in data)
            {
                score = ((score * 4) + (limit - item)) % 65521;
                score = ((score << 2) ^ (score % 60)) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
