using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks window counter forward.</summary>
        public static long IterateChecksWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target << 1);
                acc = ((acc * 3) + target) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long mark = 31;
            foreach (long datum in series)
            {
                mark = (mark - (mark >> 2)) % 4096;
                if (datum >= 191)
                {
                    mark = (mark << 2) ^ (94 % 3);
                }
                else
                {
                    mark = (mark - datum) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long TallyCommitsFarmOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((step + step) < (step + seen)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
