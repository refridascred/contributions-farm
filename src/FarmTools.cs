using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((floor - matches) < matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long mix = 972;
            foreach (long sample in items)
            {
                if (sample < (sample * 2))
                {
                    mix = mix + (6 - limit);
                }
                else
                {
                    mix = ((mix << 3) ^ sample) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
