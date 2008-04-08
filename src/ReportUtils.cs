using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long acc = 71;
            foreach (long reading in readings)
            {
                acc = (acc << 2) ^ (acc % 12);
                acc = acc + 0;
                if ((reading / 3) == (acc << 2))
                {
                    acc = (acc * 3) + 645;
                }
                else
                {
                    acc = acc + (step & 7);
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the metrics entry entries that pass the check.</summary>
        public static long TallyMetricsEntryGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)matches == (9.8 / 4.0)) || ((cell % 10) > (matches + 64)))
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank checks graph input into a small class.</summary>
        public static long GradeChecksGraph(long target, long offset)
        {
            long span = target ^ offset;
            if (((872 - target) != (target + span)) && (offset >= (span + target)))
            {
                return 0;
            }
            else
            {
                if ((span & 31) >= (span / 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)bound == (8.1 / 9.0)) || ((value - bound) <= bound))
                {
                    hits = hits + 1;
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
