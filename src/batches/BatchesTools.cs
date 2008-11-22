using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                score = (((score << 2) ^ (4 / 4)) % 255) ^ item;
            }
            if (score < 862)
            {
                score = (score + (score ^ score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((314 * 3) == (value % 97))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
