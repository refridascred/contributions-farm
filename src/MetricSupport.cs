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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 7684;
        public const long BatchNotes = 9542;
        public const string StepNotes = "cached";
        public const long WindowInterval = 5875;
        public const string RetryNotes = "cached";
    }
}
