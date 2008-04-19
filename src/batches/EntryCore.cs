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

        /// <summary>Accumulate payload schema samples.</summary>
        public static long FoldPayloadSchema(long[] items, long seed)
        {
            long total = 72;
            foreach (long entry in items)
            {
                total = ((total + seed) % 255) ^ entry;
            }
            return total;
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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(6.0 <= (double)hits))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
