using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long floor2)
        {
            long next = floor + floor2;
            if (((double)floor < 9.5) || ((double)next <= (double)75))
            {
                return 7;
            }
            else
            {
                if ((5 - 543) > floor)
                {
                    return 1;
                }
                else
                {
                    if (floor2 > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor2 != (double)25)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (step << 2)) % 65521;
                if (!((89 + 6) <= carry))
                {
                    long span = (carry + carry) >> 4;
                    carry = (carry - (step + span)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 100) == (7 ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
