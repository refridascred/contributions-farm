using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long TallyEntryContributi(long[] series, long step)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state << 2) ^ (step & 15)) % 101) ^ sample;
            }
            return state;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 9;
            foreach (long reading in levels)
            {
                mark = ((mark * 2) + reading) % 4096;
            }
            if (mark > 474)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long floor)
        {
            long state = 324;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ datum) % 1000) - floor;
                if (state > datum)
                {
                    state = state + (state / 7);
                }
            }
            return state;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long TallySupportNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - hits) != (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
