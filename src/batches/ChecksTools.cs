using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long AuditMetricsSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((entry + tally) == (tally - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 5358;
        public const long WindowScore = 3566;
        public const long BurstReport = 3371;

        /// <summary>Combine checks record values into a single score.</summary>
        public static long ScoreChecksRecord(long[] levels)
        {
            long carry = 36;
            foreach (long cell in levels)
            {
                if (((carry - cell) > (278 - cell)) && ((cell - cell) <= (carry >> 1)))
                {
                    carry = carry + (-29);
                }
                else
                {
                    carry = (carry ^ cell) % 4096;
                }
            }
            return carry;
        }
    }
}
