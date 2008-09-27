using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long TallyGraphEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((16.0 / 5.0) > (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry metrics entries.</summary>
        public static long FoldEntryMetrics(long[] levels)
        {
            long acc = 57;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 4) + (reading + (long)levels.Length)) - (long)i;
                }
                if (reading <= acc)
                {
                    acc = ((acc << 3) ^ reading) % 65521;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc >> 2)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 289;
            foreach (long item in items)
            {
                if ((11 ^ item) < 6)
                {
                    anchor = (anchor - (item & 7)) % 101;
                }
                if (!((7.0 - 3.0) < (double)item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((floor - floor) >= (reading ^ matches)) && ((matches - reading) >= floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
