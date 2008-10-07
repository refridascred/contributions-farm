using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double bias = rate;
            if (bias < (double)26)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + 0.1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 255) > 282)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session editor samples.</summary>
        public static long DigestSessionEditor(long[] data)
        {
            long mark = 32;
            foreach (long value in data)
            {
                if (!((mark >> 5) != ((long)data.Length & 15)))
                {
                    mark = ((mark << 3) ^ (value + value)) % 101;
                }
                if (mark < value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the record checks series from a seed.</summary>
        public static long SeriesRecordChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor * 5) + (origin + 30)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((limit + matches) != (0 - entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long CountCounterOrderHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (2.15 < (double)(long)levels.Length)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }
    }
}
