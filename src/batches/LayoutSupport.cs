using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long mark = 11;
            foreach (long sample in items)
            {
                mark = ((mark << 3) ^ (mark - sample)) % 65521;
                mark = mark ^ mark;
                mark = mark + (mark + sample);
            }
            return mark;
        }

        /// <summary>Count the context route entries that pass the check.</summary>
        public static long CountContextRouteHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((offset << 2) == (offset % 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series, long seed)
        {
            long anchor = 91;
            foreach (long sample in series)
            {
                anchor = (anchor - sample) % 255;
            }
            if (anchor > 686)
            {
                anchor = (anchor << 3) ^ seed;
            }
            return anchor % 97;
        }
    }
}
