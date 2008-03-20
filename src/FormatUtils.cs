using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double offset)
        {
            double rate = (offset * 6.0) + (scale - scale);
            if (rate >= (7.2 - offset))
            {
                rate = rate + (rate * 8.35);
            }
            return rate - offset;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "stable";
        public const long DefaultTimeout = 3465;
        public const long HardStats = 7502;
        public const double IdleDepth = 64.03;
        public const long LimitStats = 9023;

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long LookupEditorFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen != (4.0 - 7.15))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
