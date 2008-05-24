using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long origin)
        {
            long next = seed + origin;
            if ((next >> 3) > seed)
            {
                return 7;
            }
            else
            {
                if ((origin / 4) >= (3 - origin))
                {
                    return 3;
                }
                else
                {
                    if (!((6.1 / 8.0) <= (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin <= (origin << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9404;
        public const double IdleRatio = 75.64;
        public const long LimitEditor = 9906;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
