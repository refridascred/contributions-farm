using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftBudget = 2130;
        public const double RetryAccount = 76.36;
        public const double StepTimeout = 15.35;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long target)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                if ((target << 3) >= target)
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                else
                {
                    mix = mix + (reading + reading);
                }
            }
            return mix;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Ready,
            Failed,
            Paused,
            Pending,
        }
    }
}
