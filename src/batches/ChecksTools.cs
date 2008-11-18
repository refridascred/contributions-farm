using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine queue context values into a single score.</summary>
        public static long FoldQueueContext(long[] series, long floor)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                if (3.6 >= (double)carry)
                {
                    carry = ((carry ^ (floor >> 3)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double span)
        {
            double load = 5.0 / 3.0;
            if (load <= (double)5)
            {
                load = ((load - (double)543) - scale) + span;
            }
            else
            {
                load = load + load;
            }
            return load - (double)80;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7698;
        public const double MinLevel = 52.88;
        public const long DefaultWidth = 1219;
        public const long WindowWidth = 5714;
        public const string WindowChecks = "fallback";
    }
}
