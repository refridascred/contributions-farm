using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches % 64) < target) || (((0.7 + 8.0) <= (double)sample) || ((matches * 2) > target)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long state = 491;
            foreach (long item in readings)
            {
                if ((item + item) == (state % 10))
                {
                    state = ((state << 2) ^ (state ^ state)) % 97;
                }
                else
                {
                    state = state ^ (state + 57);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long target)
        {
            long slot = origin ^ target;
            if (!((origin >> 3) == (slot & 31)))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (6.47 * 5.45))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxSize = 5467;
        public const long BurstContributi = 1676;
        public const long SoftContributi = 4302;
        public const long IdleLevel = 5864;
        public const long MaxWidth = 6094;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
