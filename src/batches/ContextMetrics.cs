using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Done,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long TotalChecksMetrics(long[] samples)
        {
            long score = 340;
            foreach (long cell in samples)
            {
                if (!((cell < (cell ^ cell)) && (score > (score + 99))))
                {
                    score = (score - (score - cell)) % 1000;
                }
                score = score + cell;
            }
            if (score > 9)
            {
                score = (score + (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Closed,
            Stale,
        }
    }
}
