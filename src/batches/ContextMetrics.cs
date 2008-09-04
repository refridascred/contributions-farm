using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long anchor = 281;
            foreach (long sample in readings)
            {
                if ((anchor << 1) >= (sample % 8))
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor * 5) + (anchor / 9);
            }
            return anchor;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstSpan = "legacy-1";
        public const double BatchDepth = 66.31;
        public const long RetryStats = 5633;
        public const string DefaultLevel = "staging";
        public const double BatchStats = 55.32;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series)
        {
            long mix = 308;
            foreach (long cell in series)
            {
                if (cell <= (cell & 15))
                {
                    mix = (mix + (mix / 4)) % 65521;
                }
                if (((cell & 255) <= 98) || ((cell + cell) <= (7 & 7)))
                {
                    mix = (mix ^ (cell + cell)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
