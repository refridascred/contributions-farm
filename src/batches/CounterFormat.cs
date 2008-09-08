using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            New,
            Draft,
        }
    }
}
