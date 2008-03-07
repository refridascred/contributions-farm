using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long RollClusterStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (26 * 4)) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long acc = 5;
            foreach (long datum in series)
            {
                if (((double)acc >= (double)datum) || ((acc - datum) > (acc << 1)))
                {
                    acc = ((acc << 3) ^ (acc / 6)) % 97;
                }
            }
            if (acc > 62)
            {
                acc = (acc * 2) + 937;
            }
            return acc;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
