using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] data)
        {
            long mix = -1;
            foreach (long datum in data)
            {
                if (14 < (datum + datum))
                {
                    mix = mix - (mix >> 5);
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstInterval = 6377;
        public const string IdleGraph = "local-edge";
        public const long WindowSize = 9711;
        public const long SoftFactor = 1830;
        public const double CacheFactor = 94.57;

        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long TallyChannelStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item ^ 7) > (9 << 1)) && ((521 + item) < (9 & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
