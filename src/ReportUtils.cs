using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next stats session value from a seed.</summary>
        public static long RollStatsSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long SeriesGithubfarmChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long StepContextOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
