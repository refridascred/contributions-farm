using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long bound)
        {
            long carry = 532;
            foreach (long item in series)
            {
                carry = ((carry - bound) % 97) + item;
            }
            if (carry > 4)
            {
                carry = (carry - carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (step ^ 24)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)reading == (double)tally) && ((tally ^ tally) >= 24))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
