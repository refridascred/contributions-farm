using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = 458;
            foreach (long value in samples)
            {
                if (!((value & 7) != (value * 3)))
                {
                    mark = (mark - (value >> 3)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = mark + (mark / 2);
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits == (double)step)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
