using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items, long floor)
        {
            long mix = 372;
            foreach (long datum in items)
            {
                if ((datum << 1) > (mix / 7))
                {
                    mix = ((mix * 5) + (mix ^ floor)) % 4096;
                }
            }
            if (mix < 90)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
