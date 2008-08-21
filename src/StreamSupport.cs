using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - (long)series.Length) < item)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheInterval = 1451;
        public const string SoftSpan = "latest-edge";
        public const string BurstGithubfarm = "cached";
    }
}
