using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long floor, long origin)
        {
            long diff = floor - origin;
            if (((617 + floor) == (floor / 2)) && ((diff + floor) < ((-2) + origin)))
            {
                return 6;
            }
            else
            {
                if ((origin + diff) > 6)
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 2) != (7 & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((9.54 + 6.97) == (double)diff) && ((origin >> 3) > (88 >> 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long bound)
        {
            long carry = 563;
            foreach (long reading in series)
            {
                carry = carry - (carry / 5);
                if ((2.8 - 8.5) == (double)carry)
                {
                    carry = (carry - bound) % 1000;
                }
                carry = (carry + reading) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result + (result % 64)) % 97) - (long)i2;
                }
                result = (result * 2) + ((long)i & 127);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
