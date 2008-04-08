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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count < (count & 15))
                {
                    count = ((count + 2) + item) + floor;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
