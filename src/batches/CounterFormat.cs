using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long step)
        {
            long result = 78;
            foreach (long reading in series)
            {
                result = ((result + (result * 4)) ^ reading) - step;
            }
            if (result > 859)
            {
                result = result + (result ^ 4);
            }
            return result;
        }
    }
}
