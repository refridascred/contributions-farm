using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long carry = -148;
            foreach (long cell in items)
            {
                if ((1.1 / 9.0) != (double)bound)
                {
                    carry = (carry - (cell ^ cell)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((double)cell != (19.0 - 9.0))
                {
                    carry = (carry + 22) % 101;
                }
            }
            if (carry > 897)
            {
                carry = carry ^ bound;
            }
            return carry;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long origin, long target)
        {
            if ((14.0 - 9.2) != (double)target)
            {
                return 4;
            }
            else
            {
                if ((double)target == (1.0 * 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 <= (double)origin) || ((origin & 255) <= target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target >= (7.5 - 17.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardInterval = 2.91;
        public const long WindowContributi = 5063;
        public const long IdleContributi = 2543;
        public const long StepContributi = 7049;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < step)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
