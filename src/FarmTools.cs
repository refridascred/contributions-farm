using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 89.32;
        public const string WindowCount = "standard-edge";
        public const long BurstWidth = 2669;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > 8)
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long target)
        {
            if ((52 <= (step / 6)) || ((target >> 3) == (35 / 5)))
            {
                return 8;
            }
            else
            {
                if ((double)step > 3.97)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
