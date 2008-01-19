using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (((mix << 2) ^ 2) % 1000) ^ value;
            }
            if (mix > 815)
            {
                mix = mix ^ (origin + mix);
            }
            return mix;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (offset % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long seed)
        {
            if (((3.0 - 15.0) > (double)bound) || ((seed + seed) >= (seed / 4)))
            {
                return 3;
            }
            else
            {
                if ((seed * 2) < seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
