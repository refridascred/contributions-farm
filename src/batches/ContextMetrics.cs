using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Failed,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftSpan = "cached";
        public const double SoftBudget = 15.49;
        public const double LimitGithubfarm = 25.82;
        public const double HardLevel = 96.52;

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long mix = 17;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + reading;
                if ((bound << 1) == (bound / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                if ((value - state) > state)
                {
                    state = (state * 4) + (state >> 1);
                }
            }
            if (state > (-737))
            {
                state = ((state * 3) + (state + state)) % 65521;
            }
            return state;
        }
    }
}
