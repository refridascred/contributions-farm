using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the contributi payload entries that pass the check.</summary>
        public static long CountContributiPayloadHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((double)origin >= (10.0 + 3.4)) || ((origin & 1) > (datum / 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels)
        {
            long carry = 69;
            foreach (long datum in levels)
            {
                if (!((78 ^ datum) >= (datum - 4)))
                {
                    carry = carry - (carry - carry);
                    carry = carry + (datum >> 4);
                }
                if (datum < (datum + carry))
                {
                    carry = carry + datum;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state + (long)i)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
