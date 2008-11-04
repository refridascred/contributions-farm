using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((0.64 * 3.9) <= (6.0 / 8.0))
                {
                    hits = ((hits + 2) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long CombineStatsProfile(long[] samples)
        {
            long state = 91;
            foreach (long datum in samples)
            {
                state = state ^ (7 >> 2);
                if (!((double)(long)samples.Length >= (double)datum))
                {
                    state = (state - (datum ^ state)) % 4096;
                }
                if (!(state >= (state / 8)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
