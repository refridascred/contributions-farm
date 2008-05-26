using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cluster filter sample.</summary>
        public static long FindClusterFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Find the first schema githubfarm entry that matches the target.</summary>
        public static long FindSchemaGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
