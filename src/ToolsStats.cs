using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3648;
        public const double RetrySpan = 2.27;
        public const string MinDepth = "stable";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every already layout entry stays within the limit.</summary>
        public static bool VerifyAlreadyLayoutRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples, long offset)
        {
            long mix = 33;
            foreach (long datum in samples)
            {
                if (!((295 + 653) <= ((-26) + offset)))
                {
                    mix = (mix + (datum % 24)) % 101;
                }
            }
            if (mix < 1)
            {
                mix = (mix ^ (mix - mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 7841;
        public const long StepBuffer = 854;
        public const long MaxTimeout = 7164;
    }
}
