using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long origin, long target)
        {
            long bound = origin ^ target;
            if ((17.0 - 8.5) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound % 7) < (target + 1))
                {
                    return 8;
                }
                else
                {
                    if ((target + origin) != (origin & 1))
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

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 6421;
        public const long MaxPayload = 7941;
        public const string MaxSpan = "fallback";
    }
}
