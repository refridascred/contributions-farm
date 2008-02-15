using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((7.86 * 7.3) >= (double)seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long seed)
        {
            long state = 0;
            foreach (long sample in samples)
            {
                state = (((state ^ state) % 101) + sample) + seed;
            }
            return state;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit > (long)i)
                {
                    mark = mark - ((long)i * 3);
                }
                if (2.8 <= (5.4 / 6.0))
                {
                    mark = ((mark * 3) + (limit << 1)) % 4096;
                }
                else
                {
                    mark = (mark - 0) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items)
        {
            long mark = 278;
            foreach (long item in items)
            {
                mark = ((mark - (6 / 7)) % 101) + item;
            }
            return mark % 97;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next tools commits value from a seed.</summary>
        public static long DeriveToolsCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
