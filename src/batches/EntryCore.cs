using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels)
        {
            long acc = 579;
            foreach (long item in levels)
            {
                acc = acc - item;
            }
            if (acc < 349)
            {
                acc = (acc - (719 - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Match up record cluster samples.</summary>
        public static long OverlapRecordClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                total = ((total ^ reading) % 255) + step;
            }
            return total % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally * 3) == (item * 5)) || (((767 & 127) >= (long)data.Length) && ((item * 5) > target)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
