using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                if ((double)datum < (8.3 * 1.7))
                {
                    anchor = (anchor + (datum + datum)) % 65521;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of format tools readings.</summary>
        public static long ScoreFormatTools(long[] samples, long origin)
        {
            long anchor = 647;
            foreach (long reading in samples)
            {
                if (reading < (anchor ^ anchor))
                {
                    anchor = anchor ^ origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long FindChannelEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long offset)
        {
            long total = 222;
            foreach (long item in values)
            {
                total = (total * 5) + (item - offset);
            }
            return total % 1000;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 9136;
        public const long LimitScore = 9098;
        public const long CacheFactor = 8247;
        public const long BatchSpan = 2861;
    }
}
