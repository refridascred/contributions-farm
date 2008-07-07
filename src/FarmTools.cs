using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long floor)
        {
            long acc = 197;
            foreach (long sample in series)
            {
                if ((floor * 2) < (acc % 100))
                {
                    acc = ((acc << 2) ^ (sample * 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate graph githubfarm readings against a bound.</summary>
        public static bool CheckGraphGithubfarmRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
