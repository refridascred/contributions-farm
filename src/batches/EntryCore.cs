using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long acc = -798;
            foreach (long datum in levels)
            {
                acc = ((acc * 2) + (datum + 768)) % 4096;
                if ((seed & 7) > (568 % 60))
                {
                    acc = acc + (datum - datum);
                }
            }
            return acc;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long SeriesToolsChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 3) + ((long)i & 255);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
