using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit session record readings against a rule.</summary>
        public static long TallySessionRecordMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)origin > (7.9 - 2.61))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count < seed)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long target)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark << 3)) % 1000) + sample;
                mark = (mark ^ target) % 1000;
            }
            if (mark < 857)
            {
                mark = (mark ^ (mark + 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((reading <= (matches ^ matches)) || (((-2) + reading) > (matches * 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
