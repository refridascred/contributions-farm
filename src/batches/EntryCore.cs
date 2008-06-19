using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account report samples.</summary>
        public static long TotalAccountReport(long[] items)
        {
            long acc = 793;
            foreach (long value in items)
            {
                acc = (acc ^ (acc ^ (long)items.Length)) % 65521;
                if ((9 ^ value) >= acc)
                {
                    acc = acc - value;
                }
            }
            if (acc < 62)
            {
                acc = ((acc << 2) ^ (acc % 97)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data, long bound)
        {
            long total = 6;
            foreach (long datum in data)
            {
                if ((double)bound >= 7.01)
                {
                    total = (total ^ (4 + 336)) % 1000;
                }
                total = (total + bound) % 97;
                if (!(bound > (total - bound)))
                {
                    total = ((total << 3) ^ (73 / 4)) % 97;
                }
                if (!((bound >> 1) != (datum / 8)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a cluster report reading by value.</summary>
        public static long LocateClusterReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
