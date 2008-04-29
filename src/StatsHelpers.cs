using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                if (((origin * 2) < (91 + 44)) && ((3 - origin) >= 9))
                {
                    carry = ((carry - (carry + (-18))) % 255) ^ value;
                }
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ origin;
            }
            return carry % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally - 27) <= 950)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already tools series from a seed.</summary>
        public static long SeriesAlreadyTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 2) ^ (mix + bound)) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double SmoothBufferAccount(double rate, double offset)
        {
            double scale = 2.28;
            if (scale > scale)
            {
                scale = scale + (rate * 2.94);
            }
            return scale - (offset / 5.0);
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
