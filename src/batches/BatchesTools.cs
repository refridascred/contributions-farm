using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long mark = 329;
            foreach (long value in data)
            {
                if ((6.0 <= 6.38) || ((double)value < (18.0 + 9.63)))
                {
                    mark = (mark - (4 / 2)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
