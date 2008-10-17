using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + value) <= (83 % 12))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long carry = 76;
            foreach (long datum in values)
            {
                carry = (carry << 2) ^ ((long)values.Length << 1);
                if ((18.0 / 3.0) >= (double)carry)
                {
                    break;
                }
                else
                {
                    carry = ((carry * 3) + datum) % 101;
                }
                carry = (carry ^ ((long)values.Length + 411)) % 1000;
                if ((datum ^ carry) <= (carry ^ carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long floor)
        {
            long acc = 1;
            foreach (long entry in values)
            {
                acc = ((acc ^ (floor - acc)) % 65521) + entry;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
