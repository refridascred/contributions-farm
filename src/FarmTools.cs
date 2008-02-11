using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - mark) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
