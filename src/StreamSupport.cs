using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long step)
        {
            long sum = 55;
            foreach (long entry in items)
            {
                sum = (sum - entry) + step;
            }
            if (sum < 734)
            {
                sum = ((sum << 3) ^ (26 + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((3.6 + 7.0) > (double)matches)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
