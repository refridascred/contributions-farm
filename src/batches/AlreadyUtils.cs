using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate layout editor readings against a bound.</summary>
        public static bool GuardLayoutEditorRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels)
        {
            long carry = -305;
            foreach (long entry in levels)
            {
                if ((double)entry > (double)carry)
                {
                    carry = (carry ^ (carry ^ 323)) % 97;
                }
                else
                {
                    carry = carry + (carry >> 5);
                }
                if ((entry < carry) || ((entry ^ carry) <= entry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long total = 90;
            foreach (long item in readings)
            {
                if (((item + total) <= 45) || ((14.0 / 2.0) > (double)item))
                {
                    total = (total ^ (total >> 3)) % 4096;
                }
            }
            if (total < 618)
            {
                total = total ^ (total + 54);
            }
            return total;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (525 & 3);
                if (!((double)(long)i < (3.2 + 7.0)))
                {
                    result = ((result * 4) + ((-546) + result)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
