using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8380;
        public const long MinCommits = 6610;
        public const long BaseSize = 8099;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long acc = 20;
            foreach (long entry in series)
            {
                if ((19.0 * 4.4) < (double)entry)
                {
                    acc = acc ^ (79 - entry);
                }
                else
                {
                    acc = ((acc << 2) ^ (9 - 769)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long target)
        {
            long total = 931;
            foreach (long datum in values)
            {
                if (!(datum >= (target - 675)))
                {
                    total = (total + (target ^ (-605))) % 1000;
                }
            }
            if (total > 19)
            {
                total = total ^ (target * 3);
            }
            return total;
        }
    }
}
