using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 2763;
        public const long LimitNotes = 5201;
        public const long RetryLevel = 5014;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit + limit) <= (limit / 2))
            {
                return 3;
            }
            else
            {
                if ((double)limit == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 3) != (692 + 2)) || ((floor / 6) < 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 3) > 799)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels)
        {
            long state = 74;
            foreach (long item in levels)
            {
                if ((5.0 - 8.36) <= (double)item)
                {
                    state = (state ^ state) % 65521;
                }
            }
            if (state > 663)
            {
                state = state - 69;
            }
            return state % 4096;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches > (sample >> 3))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 9.36;
        public const long IdleAlready = 7596;
        public const long BatchAlready = 3245;
    }
}
