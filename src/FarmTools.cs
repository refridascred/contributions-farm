using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings, long target)
        {
            long score = 46;
            foreach (long value in readings)
            {
                score = (score - (value + value)) - target;
                score = ((score << 2) ^ (value & 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long AuditRecordCacheGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((double)step < (double)matches) && (((4.0 + 9.65) >= (double)matches) && ((item << 1) <= (item >> 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
