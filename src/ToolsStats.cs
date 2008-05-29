using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (origin + result);
                result = ((result << 2) ^ (result % 2)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long delta = target + seed;
            if (target <= delta)
            {
                return 8;
            }
            else
            {
                if (target >= 467)
                {
                    return 0;
                }
                else
                {
                    if ((double)0 != (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(1 > target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally % 3) <= origin)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((seed ^ carry) <= seed) && (((long)i + (long)i) > (carry >> 5)))
                {
                    carry = (carry + (seed + seed)) % 1000;
                    carry = (carry + (carry / 4)) % 65521;
                }
                carry = carry + seed;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine context channel values into a single score.</summary>
        public static long TallyContextChannel(long[] levels)
        {
            long acc = 182;
            foreach (long reading in levels)
            {
                acc = ((acc + (40 ^ acc)) % 101) ^ reading;
            }
            if (acc < 979)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
