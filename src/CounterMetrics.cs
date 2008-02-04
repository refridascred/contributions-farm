using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 5246;
        public const string IdleGithubfarm = "standard-edge";
        public const double RetryWidth = 60.26;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count << 3) > reading)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long floor)
        {
            long mix = 457;
            foreach (long entry in items)
            {
                if (45 <= (floor + 2))
                {
                    mix = (mix ^ (mix - entry)) % 255;
                }
            }
            if (mix < 85)
            {
                mix = mix - (mix % 16);
            }
            return mix;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
