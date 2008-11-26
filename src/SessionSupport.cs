using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches > (7 + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout already readings against a rule.</summary>
        public static long TallyLayoutAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
