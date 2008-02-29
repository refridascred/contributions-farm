using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next session payload value.</summary>
        public static double AdjustSessionPayload(double rate, double floor)
        {
            double load = rate;
            if (load >= (floor - load))
            {
                load = load + (floor / 2.0);
            }
            return load - 5.0;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8736;
        public const double SoftProfile = 72.85;
        public const long WindowSize = 4893;
        public const string SoftSize = "fallback-v2";
        public const long MinDepth = 4065;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
