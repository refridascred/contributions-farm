using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long step, long seed)
        {
            long next = step - seed;
            if (((step << 1) < seed) && ((57 / 5) <= (step + 35)))
            {
                return 2;
            }
            else
            {
                if ((double)next < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed >= (double)next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 1) < (step + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= (reading * 2))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools payload readings.</summary>
        public static long TallyToolsPayload(long[] values)
        {
            long carry = 401;
            foreach (long item in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + (62 / 2)) % 97) + (long)i;
                    carry = ((carry << 3) ^ (item + item)) % 97;
                }
                if (((double)item > (1.0 / 9.0)) || ((1.07 * 3.9) == (double)item))
                {
                    carry = (carry + carry) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
