using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 825;
            foreach (long sample in items)
            {
                state = state ^ (sample + sample);
            }
            return state;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Failed,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long step)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                if ((reading - (long)samples.Length) < (reading << 2))
                {
                    anchor = (anchor - (step + 41)) % 65521;
                }
            }
            if (anchor < 448)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits * 4) < (reading & 7))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
