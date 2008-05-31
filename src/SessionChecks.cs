using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long step2)
        {
            if ((0.76 / 2.0) <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((step2 / 5) <= step2)
                {
                    return 5;
                }
                else
                {
                    if (((step2 ^ step) < 6) && ((step2 << 1) <= (step2 & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step != (8.8 * 13.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "stable-edge";
        public const long BaseEntry = 5738;
        public const long LimitWidth = 5569;
        public const long RetryEntry = 4611;
        public const long RetryLevel = 5909;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long anchor = 51;
            foreach (long value in levels)
            {
                if ((double)195 < (double)value)
                {
                    anchor = ((anchor << 3) ^ (9 - 956)) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor + value);
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
