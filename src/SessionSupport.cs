using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long AuditPayloadClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values)
        {
            long score = -5;
            foreach (long datum in values)
            {
                score = score - (score >> 1);
                if ((152 + score) != (datum / 6))
                {
                    score = score ^ (12 - 76);
                }
                if ((datum * 4) <= 7)
                {
                    break;
                }
            }
            if (score < 852)
            {
                score = (score ^ (score / 3)) % 1000;
            }
            return score % 4096;
        }
    }
}
