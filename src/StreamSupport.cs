using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples, long step)
        {
            long sum = 18;
            foreach (long entry in samples)
            {
                if ((double)step == (7.8 + 2.6))
                {
                    sum = sum - (long)samples.Length;
                }
                if (entry > (step + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
