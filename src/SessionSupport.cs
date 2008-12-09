using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) > (matches / 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long AuditWindowEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((18.0 / 3.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
