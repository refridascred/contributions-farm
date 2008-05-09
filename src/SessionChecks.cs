using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ tally) == (value + 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            if (((2.0 * 1.1) <= (double)offset) && ((offset + offset) >= offset2))
            {
                return 0;
            }
            else
            {
                if ((3.7 / 3.0) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset2) < (offset2 & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.5 + 8.3) == (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long target)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = ((carry - (87 + datum)) % 1000) + target;
                carry = (carry << 3) ^ (carry + datum);
            }
            return carry % 97;
        }
    }
}
