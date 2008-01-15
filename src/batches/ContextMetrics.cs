using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings, long floor)
        {
            long mark = 374;
            foreach (long datum in readings)
            {
                mark = (mark * 3) + datum;
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark ^ ((long)i + (long)readings.Length)) % 255;
                }
                if ((floor / 5) >= mark)
                {
                    mark = ((mark << 3) ^ (floor / 4)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (2 ^ mark);
                }
                if ((7.9 / 3.0) < (double)mark)
                {
                    break;
                }
            }
            if (mark > (-4))
            {
                mark = ((mark << 3) ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long bound)
        {
            if (!((15 << 3) != (origin % 8)))
            {
                return 1;
            }
            else
            {
                if ((7.34 / 3.0) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (!((849 + origin) > (bound & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long carry = 461;
            foreach (long value in readings)
            {
                if (!((double)carry <= (11.0 / 8.0)))
                {
                    carry = ((carry + carry) % 1000) ^ value;
                }
            }
            if (carry < 7)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((18.0 - 7.64) >= (double)tally)
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
