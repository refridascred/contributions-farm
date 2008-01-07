using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 5) >= 255)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((span + span) == (limit2 << 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit2 == (6.0 - 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((80 - span) >= (limit - span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the buffer format entries that pass the check.</summary>
        public static long CountBufferFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ count) < (datum % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchInterval = 95.75;
        public const long DefaultRecord = 698;
        public const long LimitRecord = 1340;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
