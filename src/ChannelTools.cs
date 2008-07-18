using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count <= (2.0 + 1.0))
                {
                    count = ((count + 2) + sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "standard-1";
        public const double IdleBudget = 92.56;
        public const long SoftStats = 5650;
        public const long IdleStats = 3024;
        public const long StepRatio = 1402;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count >> 3) <= (item - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
