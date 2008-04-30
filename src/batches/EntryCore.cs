using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepCount = 5727;
        public const double BatchFormat = 91.46;
        public const double StepRatio = 14.6;
        public const long IdleRatio = 6341;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long anchor = 7;
            foreach (long item in samples)
            {
                anchor = (anchor - (anchor + item)) % 65521;
                if ((7 % 24) == (anchor ^ 7))
                {
                    anchor = (anchor * 2) + (341 + 484);
                }
                else
                {
                    anchor = ((anchor << 2) ^ item) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
