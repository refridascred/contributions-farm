using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support contributi readings.</summary>
        public static long PairSupportContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((7.38 - 8.0) < (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ mark) > 2)
                {
                    mark = ((mark * 5) + mark) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark & 1)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series, long origin)
        {
            long anchor = -480;
            foreach (long entry in series)
            {
                if (((entry ^ origin) <= (anchor * 4)) && (origin > (entry * 3)))
                {
                    anchor = (anchor + (origin & 1)) % 255;
                }
                anchor = anchor ^ (anchor + entry);
                if ((57 - entry) >= anchor)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor - (anchor >> 5)) % 65521;
                }
                if ((4 > ((long)series.Length + 4)) && ((anchor + origin) > (2 + entry)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
