using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "standard";
        public const long MinSpan = 5526;
        public const double MaxFactor = 52.03;
        public const double RetryLevel = 75.34;
        public const long RetryQueue = 9542;

        /// <summary>Rank schema window input into a small class.</summary>
        public static long SortSchemaWindow(long limit, long target)
        {
            long delta = limit + target;
            if (((limit & 3) >= limit) && (((-3) / 2) <= limit))
            {
                return 6;
            }
            else
            {
                if (!(target >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((3.43 / 6.0) != (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta / 6) >= limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
