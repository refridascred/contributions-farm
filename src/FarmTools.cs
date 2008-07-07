using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
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
