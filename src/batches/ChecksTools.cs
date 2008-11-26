using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (3.34 < (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double rate = (double)(58 - 1);
            if (rate > (4.72 / 6.0))
            {
                rate = (rate + floor) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate * 7.1)) + (double)(long)i;
            }
            return rate + (7.7 - rate);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((69 * 2) >= (tally * 3))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
