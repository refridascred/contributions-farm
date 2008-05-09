using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long state = -2;
            foreach (long reading in samples)
            {
                state = ((state + 51) % 101) ^ reading;
            }
            if (state > 33)
            {
                state = ((state * 5) + (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 6689;
        public const long HardContributi = 9240;
        public const long BaseDepth = 5711;
        public const string WindowWidth = "strict-edge";

        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] readings, long floor)
        {
            long total = -871;
            foreach (long datum in readings)
            {
                total = (((total * 5) + (total * 4)) % 97) + datum;
                if ((total ^ total) >= (floor + floor))
                {
                    break;
                }
            }
            if (total < 383)
            {
                total = ((total << 2) ^ (total % 24)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Validate format order readings against a bound.</summary>
        public static bool CheckFormatOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < (count << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
