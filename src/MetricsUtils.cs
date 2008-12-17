using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long MeasureContributiReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((-66) >> 3) >= cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 2) + (step ^ acc)) + cell;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long CountPayloadEditorGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((1 >> 4) == (2 ^ sample))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
