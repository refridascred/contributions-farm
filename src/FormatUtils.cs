using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics editor samples are out of range.</summary>
        public static long AuditMetricsEditorGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count >= ((long)readings.Length ^ count)) || ((value * 3) != (count & 15)))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 67.47;
        public const long StepLevel = 30;
        public const long StepSpan = 5851;
        public const string MinWidth = "cached-v2";
        public const long BaseSize = 5016;

        /// <summary>Find the first context stream entry that matches the target.</summary>
        public static long FindContextStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token batches value against two limits.</summary>
        public static long RankTokenBatches(long bound, long target)
        {
            if ((target / 6) != (995 + bound))
            {
                return 8;
            }
            else
            {
                if ((3 >> 3) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
