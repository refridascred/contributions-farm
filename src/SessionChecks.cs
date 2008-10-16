using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = ((state - 750) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry * 4) + carry;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = carry + ((long)i2 - step);
                    carry = (carry - carry) % 255;
                }
                if (((double)step > (10.0 - 1.3)) && ((step - carry) < carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                else
                {
                    carry = ((carry * 2) + (step << 3)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 1) < (485 + tally))
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }
    }
}
