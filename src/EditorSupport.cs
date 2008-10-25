using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTimeout = 5396;
        public const long StepRatio = 3841;
        public const long BatchScore = 4615;
        public const long BatchTools = 5714;
        public const double StepTools = 21.41;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)58)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleInterval = 8783;
        public const long MaxSession = 9681;
        public const long MaxTimeout = 3679;
        public const long IdleSession = 1692;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (target < (52 >> 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long carry = -65;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (value - (long)i)) % 65521;
                }
                if ((carry << 1) > (value - carry))
                {
                    carry = carry ^ ((-12) + carry);
                }
            }
            if (carry > 173)
            {
                carry = (carry * 3) + origin;
            }
            return carry;
        }

        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long score = 5;
            foreach (long item in samples)
            {
                score = score - (item >> 3);
            }
            return score % 4096;
        }
    }
}
