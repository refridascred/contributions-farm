using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a route session counter forward.</summary>
        public static long StepRouteSession(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = result - (target & 1);
                result = (result ^ (result << 3)) % 97;
                if (!(target <= (result >> 4)))
                {
                    result = ((result << 2) ^ (result / 2)) % 65521;
                    result = (result << 2) ^ (result & 63);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
