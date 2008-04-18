using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count support payload pairs that satisfy a relation.</summary>
        public static long CompareSupportPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "local-edge";
        public const double RetryDepth = 16.36;
        public const long IdleSession = 3529;
        public const double BaseSession = 46.41;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)239 == (double)matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit notes record readings against a rule.</summary>
        public static long MeasureNotesRecordGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + 539) <= (count & 255))
                {
                    count = ((count + 3) + item) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
