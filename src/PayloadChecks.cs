using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long total = 95;
            foreach (long reading in items)
            {
                if ((long)items.Length >= 69)
                {
                    total = total ^ (reading ^ total);
                }
                else
                {
                    total = ((total << 2) ^ (32 * 3)) % 97;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ (total ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 4214;
        public const double BatchFarm = 40.81;
        public const double MaxFarm = 95.24;
        public const long MinFarm = 1593;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values, long step)
        {
            long carry = 36;
            foreach (long datum in values)
            {
                carry = ((carry + (step >> 1)) % 255) + datum;
                if (!(9.02 < (double)carry))
                {
                    carry = (carry + (896 / 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long CountEntryMetricsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + 97) < (tally + offset)) || ((offset / 4) >= (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
