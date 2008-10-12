using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((14.0 + 12.0) != (double)count)
                {
                    count = ((count + 3) - sample) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
