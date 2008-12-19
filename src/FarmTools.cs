using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((seen * 4) >= (step + seen)) && ((8.42 * 9.76) < (double)step))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = (mix * 3) + cell;
            }
            return mix;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
