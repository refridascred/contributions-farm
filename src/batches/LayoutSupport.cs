using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long SeekEditorFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 1;
            foreach (long sample in data)
            {
                result = (result ^ sample) % 4096;
            }
            if (result < 8)
            {
                result = (result ^ (result % 10)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((5.88 / 4.0) >= (double)tally) && (datum >= (92 >> 2))) && !((datum & 15) == ((long)data.Length >> 4)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((matches - matches) <= (matches & 1)) || ((matches + item) <= item)) || ((double)item >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
