using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long floor)
        {
            long anchor = 754;
            foreach (long reading in levels)
            {
                if ((anchor << 2) <= (9 + anchor))
                {
                    anchor = (anchor - reading) % 1000;
                }
                else
                {
                    anchor = anchor ^ (reading + floor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 7249;
        public const long BurstFactor = 2482;
        public const long IdleDepth = 4244;
        public const double IdleContributi = 5.52;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Ready,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                if (!((cell >= mark) && (3.76 > (double)mark)))
                {
                    mark = (mark ^ (264 * 3)) % 65521;
                }
                mark = mark + mark;
            }
            return mark;
        }
    }
}
