using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Failed,
            New,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry + (carry / 7)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a metrics report reading by value.</summary>
        public static long LocateMetricsReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mark = 426;
            foreach (long cell in levels)
            {
                mark = mark + (1 * 4);
                mark = (mark + (cell / 2)) % 101;
                mark = (mark - target) % 255;
            }
            if (mark > (-344))
            {
                mark = (mark ^ (target & 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
