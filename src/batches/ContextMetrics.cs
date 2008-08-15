using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long CountNotesProfileMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)step <= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (seed < (sample >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long TallyFormatSupportOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
