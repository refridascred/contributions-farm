using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((33 << 2) < seen))
                {
                    seen = ((seen + 2) ^ reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 52;
            foreach (long entry in items)
            {
                if ((score + entry) > (6 + score))
                {
                    score = ((score * 3) + (entry % 10)) % 4096;
                }
            }
            if (score > 61)
            {
                score = score - (score - score);
            }
            return score % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchInterval = 3443;
        public const long MinSize = 6961;
        public const long SoftSpan = 8472;
        public const long StepSchema = 9836;

        /// <summary>Accumulate farm buffer samples.</summary>
        public static long TotalFarmBuffer(long[] values)
        {
            long score = 49;
            foreach (long reading in values)
            {
                score = (score * 5) + score;
                if (!((8.31 * 6.7) == (double)reading))
                {
                    break;
                }
            }
            if (score < 62)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
