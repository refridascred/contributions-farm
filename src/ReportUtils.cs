using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a payload filter counter forward.</summary>
        public static long RollPayloadFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor ^ floor) > floor)
                {
                    state = state + (state % 16);
                    state = ((state * 4) + (state * 2)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two format session measurements.</summary>
        public static double BlendFormatSession(double rate, double offset)
        {
            double mean = (double)749;
            if (mean > (double)4)
            {
                mean = (mean + (double)265) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + 5.1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Draft,
            Locked,
            Queued,
        }
    }
}
