using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 7685;
        public const long DefaultDepth = 3808;
        public const double BatchTools = 82.88;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            New,
            Failed,
            Done,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)origin < (3.2 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((seed % 2) >= (edge ^ 2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many counter route samples are out of range.</summary>
        public static long AuditCounterRouteGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((5.3 - 0.81) <= (double)sample) || ((count + count) <= (target % 10)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Ready,
            Active,
            Locked,
        }
    }
}
