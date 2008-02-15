using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long mix = 0;
            foreach (long value in values)
            {
                mix = mix ^ (mix << 2);
                if ((double)value == (double)20)
                {
                    mix = mix ^ mix;
                    continue;
                }
                if ((double)value >= (double)mix)
                {
                    mix = mix ^ (7 - mix);
                }
                if ((value ^ mix) >= (mix ^ value))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a entry cache sample.</summary>
        public static long SeekEntryCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (item << 3))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
