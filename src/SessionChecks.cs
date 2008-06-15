using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit commits contributi readings against a rule.</summary>
        public static long TallyCommitsContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value / 3) > (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ (limit - 50)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 2) ^ (long)i) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
