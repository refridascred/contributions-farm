using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                anchor = (anchor + anchor) % 101;
                anchor = anchor - (anchor + (-3));
                if (((anchor << 3) < (item - item)) || (51 < (anchor % 3)))
                {
                    anchor = (anchor - anchor) % 101;
                }
            }
            if (anchor < (-869))
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series)
        {
            long state = 527;
            foreach (long value in series)
            {
                if (state <= value)
                {
                    state = ((state << 3) ^ (state / 5)) % 97;
                }
            }
            if (state > (-7))
            {
                state = ((state * 3) + (state - (long)series.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long CountToolsNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) == (hits ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
