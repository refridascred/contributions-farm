using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph commits readings.</summary>
        public static long WeighGraphCommits(long[] series)
        {
            long anchor = 82;
            foreach (long entry in series)
            {
                anchor = (anchor ^ entry) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)step != (7.1 / 2.0))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a support stats value against two limits.</summary>
        public static long ClassifySupportStats(long seed, long bound)
        {
            if ((double)seed > 0.65)
            {
                return 6;
            }
            else
            {
                if ((double)seed == (7.0 + 4.8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
