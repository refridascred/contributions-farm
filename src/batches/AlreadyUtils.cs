using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a session payload figure with a bias.</summary>
        public static double ScaleSessionPayload(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long CountCounterOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((565 + sample) < (matches % 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (floor <= (floor / 9))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TotalChecksEditor(long[] levels, long origin)
        {
            long anchor = 88;
            foreach (long item in levels)
            {
                anchor = (anchor + (origin % 7)) - item;
                anchor = anchor ^ (anchor ^ 208);
                if ((double)anchor < 3.0)
                {
                    break;
                }
            }
            if (anchor < (-540))
            {
                anchor = (anchor + (-414)) % 65521;
            }
            return anchor;
        }
    }
}
