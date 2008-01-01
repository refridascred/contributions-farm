using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((seed + cell) < seed) || !((cell + cell) != (3 / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long score = 35;
            foreach (long datum in samples)
            {
                score = (((score * 2) + (score * 5)) ^ datum) - origin;
            }
            return score % 65521;
        }

        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long MeasureNotesBufferOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)entry < (4.31 / 9.0)) || (matches >= ((long)values.Length & 63))) || ((61 >> 3) <= matches))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
