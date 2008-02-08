using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long MeasureFormatContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum % 5) <= tally) && (datum < (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter profile reading.</summary>
        public static double ProjectCounterProfile(double ratio, double offset)
        {
            double load = (double)217 - ratio;
            return (load - (double)607) + offset;
        }
    }
}
