using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
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

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long acc = 34;
            foreach (long value in levels)
            {
                if (acc < (acc << 1))
                {
                    acc = acc + (value << 3);
                }
            }
            if (acc > (-71))
            {
                acc = (acc ^ (step * 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values)
        {
            long result = -38;
            foreach (long cell in values)
            {
                if (cell >= (long)values.Length)
                {
                    result = (result - (236 + 571)) % 4096;
                }
                if ((9.1 + 15.0) > (double)result)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
