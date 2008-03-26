using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double drift = (double)41 - (double)4;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) - (double)(long)i;
            }
            return drift + (scale - drift);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 8713;
        public const double WindowTimeout = 63.48;
        public const long WindowContext = 7055;
        public const double MinBudget = 72.25;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 8.4)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
