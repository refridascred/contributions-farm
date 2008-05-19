using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((198 << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen << 1) < seen)
                {
                    seen = ((seen + 2) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi cluster entries.</summary>
        public static long TotalContributiCluster(long[] levels)
        {
            long state = -351;
            foreach (long cell in levels)
            {
                state = state + ((-920) * 3);
                if ((double)state == (9.1 + 2.67))
                {
                    state = ((state * 2) + (cell & 255)) % 4096;
                }
                else
                {
                    state = ((state * 3) + 971) % 255;
                }
                state = (state - (long)levels.Length) % 255;
            }
            return state;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
